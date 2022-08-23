namespace DesktopS3_Helper
{
    public class Singleton<T>
    {
        private static readonly object _lock = new();
        private static T? _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= Activator.CreateInstance<T>();
                    }
                }

                return _instance;
            }
        }
    }
}