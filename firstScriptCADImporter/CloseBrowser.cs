﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace firstScriptCADImporter
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseBrowser recording.
    /// </summary>
    [TestModule("b26c6597-c25e-4f8c-bed2-4ff0f9bcd26e", ModuleType.Recording, 1)]
    public partial class CloseBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the firstScriptCADImporterRepository repository.
        /// </summary>
        public static firstScriptCADImporterRepository repo = firstScriptCADImporterRepository.Instance;

        static CloseBrowser instance = new CloseBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseBrowser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseBrowser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'LogInToUpchainSuccess.MsgLoginSuccessful'", repo.LogInToUpchainSuccess.MsgLoginSuccessfulInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.LogInToUpchainSuccess.MsgLoginSuccessfulInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'LogInToUpchainGoogleChrome'.", repo.LogInToUpchainGoogleChrome.SelfInfo, new RecordItemIndex(1));
            Host.Current.CloseApplication(repo.LogInToUpchainGoogleChrome.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
