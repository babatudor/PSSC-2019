namespace After
{
    public class Logger
    {
        private ILog _logService;
        
        public Logger (ILog logService) 
        {
            _logService = logService;
        }

        public void Log (string text) 
        {
            _logService.Log (text);
        }
    }
}