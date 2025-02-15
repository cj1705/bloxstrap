﻿namespace Bloxstrap
{
    public class JsonManager<T> where T : new()
    {
        public T Prop { get; set; } = new();
        public virtual string FileLocation => Path.Combine(Directories.Base, $"{typeof(T).Name}.json");

        public virtual void Load()
        {
            App.Logger.WriteLine($"[JsonManager<{typeof(T).Name}>::Load] Loading from {FileLocation}...");

            try
            {
                T? settings = JsonSerializer.Deserialize<T>(File.ReadAllText(FileLocation));

                if (settings is null)
                    throw new ArgumentNullException("Deserialization returned null");

                Prop = settings;

                App.Logger.WriteLine($"[JsonManager<{typeof(T).Name}>::Load] Loaded successfully!");
            }
            catch (Exception ex)
            {
                App.Logger.WriteLine($"[JsonManager<{typeof(T).Name}>::Load] Failed to load! ({ex.Message})");
            }
        }

        public virtual void Save()
        {
            if (!App.ShouldSaveConfigs)
            {
                App.Logger.WriteLine($"[JsonManager<{typeof(T).Name}>::Save] Save request ignored");
                return;
            }

            App.Logger.WriteLine($"[JsonManager<{typeof(T).Name}>::Save] Saving to {FileLocation}...");

            Directory.CreateDirectory(Path.GetDirectoryName(FileLocation)!);
            File.WriteAllText(FileLocation, JsonSerializer.Serialize(Prop, new JsonSerializerOptions { WriteIndented = true }));

            App.Logger.WriteLine($"[JsonManager<{typeof(T).Name}>::Save] Save complete!");
        }
    }
}
