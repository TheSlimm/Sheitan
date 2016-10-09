using Windows.ApplicationModel.Background;
using Restup.Webserver.Http;
using Restup.Webserver.Rest;


namespace BackgroundApplication3
{
    public sealed class StartupTask : IBackgroundTask
    {
        private BackgroundTaskDeferral _deferral;

        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            _deferral = taskInstance.GetDeferral();

            //register controller
            var module = new ModuleController().RegisterModule();

            var configuration = new HttpServerConfiguration()
              .ListenOnPort(8800)
              .RegisterRoute("api", module)
              .EnableCors();

            var httpServer = new HttpServer(configuration);
            
            await httpServer.StartServerAsync();

        }
    }
}
