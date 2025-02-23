﻿using System;
using System.IO;
using OpenQA.Selenium;


namespace Automation_Suite._01_Configuration_Tier.EnvironmentFiles
{

    public class Env 
    {
	    public static string strRelativePath;	    
	    public static string strExecSummaryHTMLFilePath;
	    public static string strTestResHTMLFilePath;
        public static IWebDriver webDriver;
	    public static string strCurrentApplication;
	    public static string strCurrentEnvironment;
	    public static string strCurrentModule;
	    public static string strOnError;
	    public static string strCurrentScenarioID;
	    public static string strCurrentScenarioDesc;
	    public static string strCurrentTestID;
	    public static string strCurrentTestDesc;
	    public static string strCurrentTestIterationList;
	    public static string strCurrentTestIteration;
        public static string objectNames;
	
	    public static string strCurrentUserID;
	    public static string strCurrentPassword;
        public static string strCurrentURL;

        public static string strCurrentBrowser;
        public static string strBrowserTitle;

        public static bool  boolScreenshotForPass = true;
	    public static bool  boolScreenshotForFail = true;
	    public static bool strCurrentTestStatus;
	    public static int intScreenShotCount = 0;
        public static bool boolDebugFlag;
        public static string strLoginFlag;
	
	    //System Dependent Variables
	    public static string sysNewline = Environment.NewLine;
        public static string sysFileSeperator = Path.DirectorySeparatorChar.ToString();
	
		
	    // Time to wait when searching for a GUI element in Milli seconds
	    public static int WAIT_TIME = 10000;
        public static string strConfigurationXl =  Env.sysFileSeperator + "01_Configuration_Tier" + Env.sysFileSeperator + "EnvironmentFiles" + Env.sysFileSeperator + "Configuration.xlsx";
        public static string strApplicationFd = Env.sysFileSeperator + "03_Application_Tier" + Env.sysFileSeperator + "TestData" + Env.sysFileSeperator;
        public static string strRepositoryFd = Env.sysFileSeperator + "03_Application_Tier" + Env.sysFileSeperator + "ObjectRepo" + Env.sysFileSeperator;
        public static string strTestRunResultPath = Env.sysFileSeperator + "04_Results_Tier" + Env.sysFileSeperator + "Reports" + Env.sysFileSeperator;
        public static int timeoutInSeconds = 20;
        public static string strReportFlag;
        public static string ReportsFolder = "Reports";
        public static string Backup = "Backup";
        public static string HTML = "HTML";
        public static string SCREENSHOTS = "SCREENSHOTS";
        public static string CONTEXT = "CONTEXT";
        public static string strContext = "";
        public static string URL = "URL";
        public static string TestDeveloperName = "Test Developer Name";
        public static string strDeveloperName = "Ankita";
        public static string Browser = "Browser";
        public static string strBrowser = "Firefox";
        public static string ScreenShotExtention = ".png";
        public static string Pass = "Pass";
        public static string Fail = "Fail";
        public static string Info = "Info";
        public static string Warning = "Warning";
        public static string Snapshot_Below = "Snapshot_Below";
        public static string UserName;
        public static string HtmlExtention = ".html";

        //Global Folder structure variables 
        //Note: To be changed - Capture data from Excel
        public static string Configuration_Tier = "Configuration_Tier";
        public static string Utility_Tier = "Utility_Tier";
        public static string Application_Tier = "Application_Tier";
        public static string Results_Tier = "Results_Tier";
        public static string ObjectRepo = "ObjectRepo";
        public static string TestData = "TestData";
        public static string EnvironmentFiles = "EnvironmentFiles";
        public static string Env_Config = "Env_Config";
        public static string Configuration_xlsx = "Configuration.xlsx";
        public static string Scenarios = "Scenarios";
        public static string TestScriptId = "TestScriptId =";
        public static string TestSheet = "TestSheet";
        public static string Run = "Run";
        public static string bin = "bin";
        public static string strcurrentBrowserVersion = "";
        public static string strExceptionelement = "";

        public static string strAttibuteValue = null;
        public static string homePageText = null;
        public static string PageTitle = "Pobal";
        public static string EXCEL_TEST_URL = @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\TestData.xlsx";
        public static string Data_Retrieve ;
        public static string Email_Id;
        public static string IBAN;
        public static string AccountName;
        public static string Bank;
        public static string BIC;
        public static string SortCode;
        public static string BankName;
        public static string ChildName;
        public static string ChildSurname;
        public static string DateOfBirth;
        public static string ChildIdentifierCode;
        public static string EXCEL_BANK_DATA = @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\Configuration_Tier\Book1.xlsx";
        public static string BANK_NAME = @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\BankAccountName.xlsx";
        
        public static string EXCEL_TEST_CHILD_DATA = @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\Application_Tier\PageObjectRepository\ApplicantPortal\Applicant_Portal_Details.xlsx";
    }
}
