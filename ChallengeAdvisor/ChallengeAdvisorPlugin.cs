using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ManiaNet.DedicatedServer.Controller.Plugins.ChallengeAdvisor
{
    [RegisterPlugin("ChallengeAdvisor", author: "Banane9", name: "Challenge Advisor")]
    public class ChallengeAdvisorPlugin : ControllerPlugin
    {
        public override bool Load(ServerController controller)
        {
            return isAssemblyServerController(Assembly.GetExecutingAssembly());
        }

        public override void Run()
        { }

        public override bool Unload()
        {
            return isAssemblyServerController(Assembly.GetExecutingAssembly());
        }
    }
}