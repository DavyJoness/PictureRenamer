using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using PictureRenamer.Models;
using NLog;

namespace PictureRenamer.ViewModels
{
    public class MainWindowViewModel: Screen
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private string _path;
        private string _log;
        private int _complete;
        private bool _isRunning;

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }


        public int Complete
        {
            get { return _complete; }
            set 
            { 
                _complete = value;
                NotifyOfPropertyChange(() => Complete);
            }
        }


        public string Log
        {
            get { return _log; }
            set 
            { 
                _log = value;
                NotifyOfPropertyChange(() => Log);
            }
        }


        public string Path
        {
            get { return _path; }
            set 
            { 
                _path = value;
                NotifyOfPropertyChange(() => Path);
            }
        }


        public MainWindowViewModel()
        {
            IsRunning = false;
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "log.txt" };

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            NLog.LogManager.Configuration = config;
        }

        public void SetPath()
        {
            Path = PathReader.SelectPath();
        }

        public void Run()
        {
            IsRunning = !IsRunning;

            if (IsRunning)
            {
                Task task = new Task(GetMessage);
                task.Start();
            }
        }

        public async void GetMessage()
        {
            string message = "";
            Renamer.Path = Path;

            int fileIndexes;
            message = Renamer.GetFileList(out fileIndexes);
            SetMessage(message);

            for (int i = 0; i < fileIndexes; i++)
            {
                if (!IsRunning)
                {
                    Complete = 0;
                    break;
                }

                message = Renamer.RenameFile(i);
                SetMessage(message);
                SetProgressBar(i, fileIndexes);
            }
        }

        private void SetMessage(string message)
        {
            Log += message + Environment.NewLine;
            Logger.Info(message);
        }
        private void SetProgressBar(int i, int totalIndexes)
        {
            decimal l = Convert.ToDecimal(i + 1) / totalIndexes;
            Complete = Convert.ToInt32(l * 100);
        }
    }
}
