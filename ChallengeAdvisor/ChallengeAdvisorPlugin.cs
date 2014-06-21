using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.Controller.Plugins.ChallengeAdvisor
{
    [RegisterPlugin("ChallengeAdvisor", author: "Banane9", name: "Challenge Advisor")]
    public class ChallengeAdvisorPlugin : ControllerPlugin
    {
        public override bool Load(ServerController controller)
        {
            return true;
        }

        public override void Run()
        {
        }

        public override bool Unload()
        {
            return true;
        }
    }
}