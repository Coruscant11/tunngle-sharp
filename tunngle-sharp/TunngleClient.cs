using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TunngleSharp
{
    public class TunngleClient
    {
        private static object lockObj = new object();
        private static string InitProject;
        
        public static TunngleClient Instance { get; private set; }

        //Once per application
        private TunngleClient(string project)
        {
            InitProject = project;
            Interop.Init(project);
        }

        public virtual TunngleClient GetInstance(string project)
        {
            if (project == InitProject || Instance == null)//project names match, or we've not initialized
                if (Instance != null)//we've already initialized
                    return Instance;
                else//we've not initialized
                {
                    lock (lockObj)
                        if (Instance == null)
                            Instance = new TunngleClient(project);
                    return Instance;
                }
            return null;
        }
    }
}
