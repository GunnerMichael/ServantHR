using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServantHR.Database.Tests
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CreateANewJobTitleTestHandleNull_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CreateANewJobTitleTestValidName_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CreateANewJobTitleDisallowDuplicates_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            this.dbo_CreateANewJobTitleTestHandleNullData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_CreateANewJobTitleTestValidNameData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_CreateANewJobTitleDisallowDuplicatesData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_CreateANewJobTitleTestHandleNull_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_CreateANewJobTitleTestValidName_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_CreateANewJobTitleDisallowDuplicates_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_CreateANewJobTitleTestHandleNull_TestAction
            // 
            resources.ApplyResources(dbo_CreateANewJobTitleTestHandleNull_TestAction, "dbo_CreateANewJobTitleTestHandleNull_TestAction");
            // 
            // dbo_CreateANewJobTitleTestValidName_TestAction
            // 
            dbo_CreateANewJobTitleTestValidName_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_CreateANewJobTitleTestValidName_TestAction, "dbo_CreateANewJobTitleTestValidName_TestAction");
            // 
            // dbo_CreateANewJobTitleDisallowDuplicates_TestAction
            // 
            resources.ApplyResources(dbo_CreateANewJobTitleDisallowDuplicates_TestAction, "dbo_CreateANewJobTitleDisallowDuplicates_TestAction");
            // 
            // dbo_CreateANewJobTitleTestHandleNullData
            // 
            this.dbo_CreateANewJobTitleTestHandleNullData.PosttestAction = null;
            this.dbo_CreateANewJobTitleTestHandleNullData.PretestAction = null;
            this.dbo_CreateANewJobTitleTestHandleNullData.TestAction = dbo_CreateANewJobTitleTestHandleNull_TestAction;
            // 
            // dbo_CreateANewJobTitleTestValidNameData
            // 
            this.dbo_CreateANewJobTitleTestValidNameData.PosttestAction = null;
            this.dbo_CreateANewJobTitleTestValidNameData.PretestAction = null;
            this.dbo_CreateANewJobTitleTestValidNameData.TestAction = dbo_CreateANewJobTitleTestValidName_TestAction;
            // 
            // dbo_CreateANewJobTitleDisallowDuplicatesData
            // 
            this.dbo_CreateANewJobTitleDisallowDuplicatesData.PosttestAction = null;
            this.dbo_CreateANewJobTitleDisallowDuplicatesData.PretestAction = null;
            this.dbo_CreateANewJobTitleDisallowDuplicatesData.TestAction = dbo_CreateANewJobTitleDisallowDuplicates_TestAction;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "1";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        [ExpectedException(typeof(SqlException))]
        public void dbo_CreateANewJobTitleTestHandleNull()
        {
            SqlDatabaseTestActions testActions = this.dbo_CreateANewJobTitleTestHandleNullData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void dbo_CreateANewJobTitleTestValidName()
        {
            SqlDatabaseTestActions testActions = this.dbo_CreateANewJobTitleTestValidNameData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        [ExpectedException(typeof(SqlException))]
        public void dbo_CreateANewJobTitleDisallowDuplicates()
        {
            SqlDatabaseTestActions testActions = this.dbo_CreateANewJobTitleDisallowDuplicatesData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }


        private SqlDatabaseTestActions dbo_CreateANewJobTitleTestHandleNullData;
        private SqlDatabaseTestActions dbo_CreateANewJobTitleTestValidNameData;
        private SqlDatabaseTestActions dbo_CreateANewJobTitleDisallowDuplicatesData;
    }
}
