//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpecExplorer.TestSuite {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpecExplorer.Sample;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3146.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ComPortTestSuite : VsTestClassBase {
        
        public ComPortTestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize() {
            this.InitializeTestManager();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup() {
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS0() {
            this.Manager.BeginTest("ComPortTestSuiteS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S24\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S36\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S44\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S10
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS10() {
            this.Manager.BeginTest("ComPortTestSuiteS10");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S29\'");
            this.Manager.Comment("executing step \'call send(\"\")\'");
            COMPort.send("");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S49\'");
            this.Manager.Comment("executing step \'call send(\"Test:\\nHello world!\")\'");
            COMPort.send("Test:\\nHello world!");
            this.Manager.Comment("reaching state \'S56\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S61\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S12
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS12() {
            this.Manager.BeginTest("ComPortTestSuiteS12");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("executing step \'call send(\"Test\")\'");
            COMPort.send("Test");
            this.Manager.Comment("reaching state \'S42\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S50\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S14
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS14() {
            this.Manager.BeginTest("ComPortTestSuiteS14");
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("executing step \'call send(\"Test:\\nHello world!\")\'");
            COMPort.send("Test:\\nHello world!");
            this.Manager.Comment("reaching state \'S43\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S16
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS16() {
            this.Manager.BeginTest("ComPortTestSuiteS16");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.Comment("executing step \'call close(\"COM28\")\'");
            COMPort.close("COM28");
            this.Manager.Comment("reaching state \'S17\'");
            this.Manager.Comment("checking step \'return close\'");
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S18
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS18() {
            this.Manager.BeginTest("ComPortTestSuiteS18");
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("executing step \'call send(\"\")\'");
            COMPort.send("");
            this.Manager.Comment("reaching state \'S19\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S33\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS2() {
            this.Manager.BeginTest("ComPortTestSuiteS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S25\'");
            this.Manager.Comment("executing step \'call close(\"COM28\")\'");
            COMPort.close("COM28");
            this.Manager.Comment("reaching state \'S37\'");
            this.Manager.Comment("checking step \'return close\'");
            this.Manager.Comment("reaching state \'S45\'");
            this.Manager.Comment("executing step \'call close(\"COM28\")\'");
            COMPort.close("COM28");
            this.Manager.Comment("reaching state \'S52\'");
            this.Manager.Comment("checking step \'return close\'");
            this.Manager.Comment("reaching state \'S57\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S20
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS20() {
            this.Manager.BeginTest("ComPortTestSuiteS20");
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("executing step \'call send(\"Test\")\'");
            COMPort.send("Test");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S22
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS22() {
            this.Manager.BeginTest("ComPortTestSuiteS22");
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.Comment("executing step \'call send(\"Test:\\nHello world!\")\'");
            COMPort.send("Test:\\nHello world!");
            this.Manager.Comment("reaching state \'S23\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S35\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS4() {
            this.Manager.BeginTest("ComPortTestSuiteS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S26\'");
            this.Manager.Comment("executing step \'call send(\"\")\'");
            COMPort.send("");
            this.Manager.Comment("reaching state \'S38\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S46\'");
            this.Manager.Comment("executing step \'call close(\"COM28\")\'");
            COMPort.close("COM28");
            this.Manager.Comment("reaching state \'S53\'");
            this.Manager.Comment("checking step \'return close\'");
            this.Manager.Comment("reaching state \'S58\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS6() {
            this.Manager.BeginTest("ComPortTestSuiteS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S27\'");
            this.Manager.Comment("executing step \'call send(\"\")\'");
            COMPort.send("");
            this.Manager.Comment("reaching state \'S39\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S47\'");
            this.Manager.Comment("executing step \'call send(\"\")\'");
            COMPort.send("");
            this.Manager.Comment("reaching state \'S54\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S59\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S8
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ComPortTestSuiteS8() {
            this.Manager.BeginTest("ComPortTestSuiteS8");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call open(\"COM28\")\'");
            COMPort.open("COM28");
            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("checking step \'return open\'");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.Comment("executing step \'call send(\"\")\'");
            COMPort.send("");
            this.Manager.Comment("reaching state \'S40\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S48\'");
            this.Manager.Comment("executing step \'call send(\"Test\")\'");
            COMPort.send("Test");
            this.Manager.Comment("reaching state \'S55\'");
            this.Manager.Comment("checking step \'return send\'");
            this.Manager.Comment("reaching state \'S60\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}
