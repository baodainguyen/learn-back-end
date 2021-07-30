using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Common
{
    public class Constants
    {
        public const string RawUrlOverView = "/Pages/CrmOverview.aspx?enparam=";
        public const string RawUrlFrontEnd = "/Pages/CrmFrontEnd.aspx?enparam=";

        public const string TEMPLATE_SEPARATE = "{@|";
        public const string COMPETITION_COLOR = "#fb9f00";
        public const int PAGE_SIZE = 15;
        public const int PAGE_SIZE_HISTORY = 15;

        public const string MKEY_TREND_MIN = "T_Min";
        public const string MKEY_TREND_MAX = "T_Max";
        public const int COLOR_DEFAULT = 200;

        public const Int64 totalSecondofDay = 86400;//24h * 60m * 60s;

        public const string ReportLangKeyTitle = "Title";
        public const string ReportLangKeyProject = "Project";
        public const string ReportLangKeyYear = "Year";
        public const string ReportLangKeyIncomeCountry = "IncomeCountry";
        public const string ReportLangKeyIncomeRegion = "IncomRegion";
        public const string ReportLangKeyIncomeToMarket = "IncomeAccordingToMarketsegment";

        public const string ReportLangKeyIncomeTotalLand = "IncomeTotalLand";
        public const string ReportLangKeyIncomeTotalMarket = "IncomeTotalMarket";

        public const string ReportLangKeyStakeholderGroup = "StakeholderGroup";
        public const string ReportLangKeyHeaderMarketName = "HeaderMarketName";
        public const string ReportLangKeyCrowdProjectParamDescription = "CrowdProjectParamDescription";
        public const string ReportLangKeyAnswerTitle = "AnswerTitle";
        public const string ReportLangKeyLblMaxString = "LblMaxString";
        public const string ReportLangKeyLblMinString = "LblMinString";
        public const string ReportLangKeyAverageString = "AverageString";
        public const string ReportLangKeyLblQuestionTitle = "LblQuestionTitle";
        public const string ReportLangKeyLblQuestionDescription = "LblQuestionDescription";
        public const string ReportLangKeyPersonParamDescription = "PersonParamDescription";
        public const string ReportLangKeyLblFollowUpOf = "ReportLangKeyLblFollowUpOf";

        public const string ReportLangKey3rdConditionAllName = "3rdConditionAllName";
        public const string ReportLangKey3rdConditionLandName = "3rdConditionLandName";
        public const string ReportLangKey3rdConditionBranchName = "3rdConditionBranchName";
        public const string ReportLangKey3rdConditionNumberOfStaff = "3rdConditionNumberOfStaff";
        public const string ReportLangKeyTableofContents = "TableofContents";
        public const string ReportLangKeyCreateFor = "Createfor";
        public const string ReportLangKeyOptionForActions = "Options for action";
        public const string ReportLangKeyReportinDetail = "Reports in detail";

        public const string ReportLangKeySeries = "Reports in detail";
        public const string ReportLangKeyPersonalEvaluation = "PersonalEvaluation";
        public const string ReportLangKeyGeneralBranchLand = "GeneralBranchLand";
        public const string ReportLangKeyPageInfo = "PageInfo";
        public const string ReportLangKeyDate = "Date";
        public const string ReportLangKeyFunction = "Function";
        public const string ReportLangKeyUserName = "UserName";
        public const string ReportLangKeyActionPlan = "ActionPlan";
        public const string ReportLangKeyDescription = "Description";
        public const string ReportLangKeyDescription2 = "Description2";
        public const string ReportLangKeyPurpose = "Purpose / Principles";
        public const string ReportLangKeyArrived = "Arrived result / situation";
        public const string ReportLangKeyResponsibility = "Responsibility";
        public const string ReportLangKeyResponsibility2 = "Responsibility2";
        public const string ReportLangKeyActualCost = "ReportLangKeyActualCost";
        public const string ReportLangKeyBegin = "Begin";
        public const string ReportLangKeyBeginDate = "BeginDate";
        public const string ReportLangKeyEnd = "End";
        public const string ReportLangKeyEndDate = "EndDate";
        public const string ReportLangKeyBudget = "Budget";
        public const string ReportLangKeyExpectedCost = "ExpectedCost";
        public const string ReportLangKeyExpectedEffect = "ExpectedEffect";
        public const string ReportLangKeyActionExpectedEffect = "ActionExpectedEffect";
        public const string ReportLangKeyActionExpectedEffect2 = "ActionExpectedEffect2";
        public const string ReportLangKeyActualEffect = "OccurredEffect";
        public const string ReportLangKeyActualEffect2 = "OccurredEffect2";
        public const string ReportLangKeyCategory = "Category";
        public const string ReportLangKeyField = "Field";
        public const string ReportLangKeyEvaluation = "Evaluation";
        public const string ReportLangKeyInstrument = "Instrument";
        public const string ReportLangKeyStatus = "Status";
        public const string ReportLangKeyAdvertisingmaterial = "Advertisingmaterial";
        public const string ReportLangKeyAdvertiser = "Advertiser";
        public const string ReportLangKeySubjetThema = "SubjetThema";

        public const string ReportLangKeyOf = "Of";
        public const string DirectLink = "Direktlink";
        public const string ReportLangKeyVisitingReport = "VisitingReport";
        public const string ReportLangKeyVendor = "Vendor";
        public const string ReportLangKeyTimePeriod = "TimePeriod";
        public const string ReportLangKeyNumberOfClientContact = "NumberOfClientContacts";
        public const string ReportLangKeyNumberOfClientContactPerDay = "NumberOfClientContactsPerDay";
        public const string ReportLangKeyContactQuality = "ContactQuality";
        public const string ReportLangKeyChartTitle = "ChartTitle";
        public const string ReportLangKeyPerson = "Person";
        public const string ReportLangKeyFromDate = "FromDate";
        public const string ReportLangKeyToDate = "ToDate";
        public const string ReportLangKeyDetailTitle = "DetailTitle";
        public const string ReportLangKeyInvalidData = "InvalidData";

        public const string ReportLangKeyMainGoalName = "MainGoalName";
        public const string ReportLangKeySubGoalName = "SubGoalName";
        public const string ReportLangKeyActionName = "ActionName";
        public const string ReportLangKeyStatusProtocol = "StatusProtocol";
        public const string ReportLangKeyDate2 = "Date2";
        public const string ReportLangKeyStatus2 = "Status2";
        public const string ReportLangKeyComment = "Comment";
        public const string ReportLangKeyCreatedOn = "CreatedOn";

        #region lang for AusgefullterFragebogen (Auto-pdf)
        public const string ReportLangKeyOrgName = "OrganizeName";
        public const string ReportLangKeyPersonFullName = "PersonFullName";
        public const string ReportLangKeyPersonEmail = "PersonEmail";
        public const string ReportLangKeyPersonIpAddress = "PersonIpAddress";
        public const string ReportLangKeyPersonHostName = "PersonHostName";
        public const string ReportLangKeyPersonRemotePort = "PersonRemotePort";
        public const string ReportLangKeyPersonProtocol = "PersonProtocol";
        public const string ReportLangKeyPersonEmuleId = "PersonEmuleId";
        public const string ReportLangKeyPersonProxy = "PersonProxy";
        public const string ReportLangKeyPersonLand = "PersonLand";
        public const string ReportLangKeyPersonRegion = "PersonRegion";
        public const string ReportLangKeyPersonCity = "PersonCity";
        public const string ReportLangKeyPersonLastChange = "PersonLastChange";
        public const string ReportLangKeyPersonPointOfPresence = "PersonPointOfPresence";
        public const string ReportLangKeyActName = "ActivityName";
        public const string ReportLangKeyActStart = "ActivityStart";
        public const string ReportLangKeyTo = "To";
        public const string ReportLangKeyFrom = "From";
        public const string ReportLangKeyPhone = "Phone";
        public const string ReportLangKeyActNameTitle = "ActivityNameTitle";
        #endregion

        #region ReportKpi
        public const string RpKpiPlan = "RpKpiPlan";
        public const string RpKpiIst = "RpKpiIst";
        public const string RpKpiAdvs = "RpKpiAdvs";
        public const string RpKpiBrutto = "RpKpiBrutto";
        public const string RpKpiNetto = "RpKpiNetto";
        public const string RpKpiDirectOutcome = "RpKpiDirectOutcome";
        public const string RpKpiUnit = "RpKpiUnit";
        public const string RpKpiNumberContact = "RpKpiNumberContact";
        public const string RpKpiTsdBrutto = "RpKpiTsdBrutto";
        public const string RpKpiTsdNetto = "RpKpiTsdNetto";
        public const string RpKpiFazit = "RpKpiFazit";
        public const string RpKpiIndirectOutcome = "RpKpiIndirectOutcome";
        public const string RpKpiSubgoal = "RpKpiSubgoal";
        public const string RpKpiScope = "RpKpiScope";
        public const string RpKpiProduct = "RpKpiProduct";
        public const string RpKpiPlace = "RpKpiPlace";
        public const string RpKpiStackholderGroup = "RpKpiStackholderGroup";
        public const string RpKpiBruttoAuf = "RpKpiBruttoAuf";
        public const string RpKpiNettoAuf = "RpKpiNettoAuf";
        public const string RpKpiAbw = "RpKpiAbw";
        public const string RpkpiResponsibility = "RpkpiResponsibility";
        public const string RpkpiStartdate = "RpkpiStartdate";
        public const string RpkpiEnddate = "RpkpiEnddate";
        public const string ActionNameExcelRP = "ActionNameExcelRP";
        public const string KpiNameExcelRP = "KpiNameExcelRP";
        #endregion

        public const string ReportBindingTypeStoreProcedure = "StoreProcedure";
        public const string ReportBindingTypeObjectBinding = "ObjectBinding";
        //End SONPT

        public const string UrlMarketting = "Pages/MsMarketSegment.aspx?";
        public const string UrlCrm = "Pages/CrmOrganisation.aspx?";

        public const string UrlMarketSegment = "Pages/MsMarketSegment.aspx?";
        public const string UrlSubMarketProduct = "Pages/MsSubMarketProduct.aspx?";
        public const string UrlGoalAction = "Pages/MsGoalAction.aspx?";
        public const string UrlMarketingMix = "Pages/MsMarketingMix.aspx?";
        public const string UrlTeamboard = "Pages/MsTeamboard.aspx?";
        public const string UrlDashboard = "Pages/Dashboard.aspx?";
        public const string UrlRoadMap = "Pages/MsRoadmap.aspx?";

        //public const string INFO_TABLE_ALIAS = "i";
        //public const string ADDRESS_TABLE_ALIAS = "ad";
        public const string CRM_TABLE_ALIAS = "o";
        //public const string BRANCH_TABLE_ALIAS = "b";
        //public const string EMPLOYEE_TABLE_ALIAS = "e";
        //public const string LEGALFORM_TABLE_ALIAS = "lf";
        //public const string TAG_TABLE_ALIAS = "t";
        public const string PERSON_TABLE_ALIAS = "p";
        public const string ACTIVITY_TABLE_ALIAS = "a";
        //public const string ACCOUNT_TABLE_ALIAS = "ap";
        //public const string STATUS_TABLE_ALIAS = "sp";
        public const string POSITION_TABLE_ALIAS = "cp";
        //public const string SUFFIX_ALIAS = "g";
        //public const string CAT_TABLE_ALIAS = "c";


        public const string CRMINFO_VIEW = "CrmInformationFilterView";
        public const string CRMADDRESS_VIEW = "CrmAddressView";
        public const string CRMTAG_VIEW = "CrmTagView";
        public const string CRMPOSITON_VIEW = "CrmPositionView";
        public const string CRMORGANISATON_ACTIVITY_VIEW = "CrmOrganisationViewForFilterByActivityId";
        public const string CRMPERSON_ACTIVITY_VIEW = "CrmPersonViewForFilterByActivityId";
        public const string CRMSTATUS_ACTIVITY_VIEW = "CrmStatusProtocolViewForFilterByActivity";
        public const string CRMACCOUNT_ACTIVITY_VIEW = "CrmActivityPersonViewForFilter";
        public const string CRMORGANISATON_WITH_PERSON_VIEW = "CrmOrganisationWithPersonView";
        public const string CRMCATEGORY_ACTIVITY_VIEW = "CrmActivityCategoryViewForFilter";
        public const string CRMPRIORITY_ACTIVITY_VIEW = "CrmActivityPriorityViewForFilter";
        //public const string CRMNOTE_ORGANISATON_VIEW = "CrmOrganisationNoteViewForFilter";
        //public const string CRMEMPLOYEE_ORGANISATON_VIEW = "CrmOrganisationEmployeeViewForFilter";
        //public const string CRMBRANCH_ORGANISATON_VIEW = "CrmOrganisationBranchViewForFilter";
        public const string CRMORGANISATION_RESPONSIBILITY_VIEW = "CrmOrganisationResponsibilityForFilter";
        public const string CRMSTATUS_LASTSTATUS_VIEW = "CrmStatusProtocolViewLastStatus";


        public const string CRM_COLUMN_NAME = "Name";
        public const string PERSON_COLUMN_NAME = "PersonName";
        public const string INFO_COLUMN_NAME = "Value";
        public const string STREET_COL = "Street";
        public const string ADDITIONADDRESS_COL = "AdditionAddress";
        public const string PLZ_COL = "Plz";
        public const string NR_COL = "Nr";
        public const string ORT_COL = "Ort";
        public const string LAND_COL = "CrmLandName";
        public const string TAG_COL = "TagName";
        public const string NOTE_COL = "Note";
        public const string CAT_COL = "CatName";
        public const string PRIORITY_COL = "PiorityName";
        public const string STATUS_COL = "StatusName";
        public const string CREATED_DATE_COL = "CreatedDate";
        public const string START_DATE_COL = "StartDate";
        public const string DUE_DATE_COL = "DueDate";
        public const string FINISH_COL = "Finish";
        public const string ACCOUNT_NAME_COL = "AccountName";
        public const string FIRST_NAME_COLUMN_NAME = "FirstName";
        public const string LAST_NAME_COLUMN_NAME = "LastName";
        public const string BIRTHDAY_COLUMN_NAME = "BirthDay";
        public const string BRANCH_COLUMN_NAME = "BranchName";
        public const string LEGALFORM_COLUMN_NAME = "LegalForm";
        public const string EMPLOYEE_COLUMN_NAME = "Employee";
        public const string REVENUE_COLUMN_NAME = "Revenue";
        public const string POSITION_COLUMN_NAME = "PositionName";
        public const string ORGANISATION_COLUMN_NAME = "OrganisationName";
        public const string STATUS_DATE_COL = "StatusDate";
        public const string CRMPERSON_RESPONSIBILITY_VIEW = "CrmPersonResponsibilityForFilter";
        public const string STATUSID_COLUMN_NAME = "StatusName";
        public const string ISWEBFORM_COL = "IsWebForm";
        public const string CREATEDDATE_COL = "CreatedDate";
        public const string MODIFIEDDATE_COL = "ModifiedDate";

        public const string SELECTALL_GE = "Alle auswählen";
        public const string SELECTALL_EN = "Select all";
        //public const string RESOURCE_COLUMN_NAME = "ResourceName";
        //public const string NETWORK_COLUMN_NAME = "NetworkName";
        //public const string COMPETENCE_COLUMN_NAME = "CompetenceName";
        //public const string CATEGORY_COLUMN_NAME = "CategoryName";






        public const string CRM_ORG_FILE_ASSIGN = "crmorganisation";
        public const string CRM_ACTIVITY_FILE_ASSIGN = "crmactivity";
        public const string CRM_PERSON_FILE_ASSIGN = "crmperson";
        public const string CRM_STATUSPROTOCOL_FILE_ASSIGN = "crmstatusprotocol";
        public const string MKT_ACTION_TODO_FILE = "actiontodofile";

        public const string CRM_FOLDER_FILE_ASSIGNFORACTIVITY = "activityfiles";
        public const string CRM_FOLDER_FILE_ASSIGNFORPERSONAL = "personfiles";
        public const string CRM_FOLDER_FILE_ASSIGNFORORGANIZE = "organisationfiles";
        public const string CRM_FOLDER_DIRECTFILEROOTFOLDER = "directfiles";

        public const int STRATEGY_QUANTITY = 2;



        //--!>HoaND
        public const string ParamWebConfigCrowdId = "CrowdProjectId";
        public const string ParamKarierenankerRepxPath = "/Markets/Charts/Karierenanker.repx";
        public const string ParamKarierenankerCrowdId = "KarierenankerCrowdId";
        public const string ParamKarierenankerLoader = "Loader";
        public const string ParamKarierenankerPerson = "PersonName";
        public const string TempExportFolder = "/TempExport";
        public const string ParamIeBrowserType = "IEBrowserCollect";
        //<!--

        #region AusgefullterFragebogen (Auto-pdf)        
        public const string ParamAusgefullterFragebogenPath = "/Markets/Charts/AusgefullterFragebogenObjectBinding.repx";
        public const string ParamAusgefullterFragebogenCrowdId = "CrowdProjectId";
        public const string ParamAusgefullterFragebogenCrowdName = "CrowdProjectName";
        public const string ParamAusgefullterFragebogenPersonId = "PersonId";
        public const string ParamAusgefullterFragebogenLang = "Lang";
        public const string ParamAusgefullterFragebogenLangMin = "LangMin";
        public const string ParamAusgefullterFragebogenLangMax = "LangMax";
        public const string ParamAusgefullterFragebogenLangChose = "LangChose";

        public const string ParamAusgefullterFragebogenPersonOrgName = "PersonOrgName";
        public const string ParamAusgefullterFragebogenPersonName = "PersonName";
        public const string ParamAusgefullterFragebogenPersonMail = "PersonEmail";
        public const string ParamAusgefullterFragebogenPersonIpAddress = "PersonIpAddress";
        public const string ParamAusgefullterFragebogenPersonHostName = "PersonHostName";
        public const string ParamAusgefullterFragebogenRemotePort = "PersonRemotePort";
        public const string ParamAusgefullterFragebogenProtocol = "PersonProtocol";
        public const string ParamAusgefullterFragebogenEmuleId = "PersonEmuleId";
        public const string ParamAusgefullterFragebogenProxy = "PersonProxy";
        public const string ParamAusgefullterFragebogenLand = "PersonLand";
        public const string ParamAusgefullterFragebogenRegion = "PersonRegion";
        public const string ParamAusgefullterFragebogenCity = "PersonCity";
        public const string ParamAusgefullterFragebogenPersonLastChange = "PersonLastChange";
        public const string ParamAusgefullterFragebogenPointOfPresence = "PointOfPresence";
        public const string ParamAusgefullterFragebogenActName = "ActivityName";
        public const string ParamAusgefullterFragebogenActDate = "ActivityDate";
        public const string ParamAusgefullterFragebogenActStart = "ActivityStart";
        public const string ParamAusgefullterFragebogenActDue = "ActivityDue";

        public const string ParamAusgefullterFragebogenActNameTitle = "ActivityNameTitle";
        public const string ParamAusgefullterFragebogenFrom = "From";
        public const string ParamAusgefullterFragebogenTo = "To";
        public const string ParamAusgefullterFragebogenPhone = "Phone";
        public const string ParamAusgefullterFragebogenPersonPhone = "PersonPhone";
        #endregion

        public const string ReportTypeCrowd = "crowd";

        //client vmCommon.enumType
        public const string FolderFieldAssignTypeMarket = "market";
        public const string FolderFieldAssignTypeLand = "land";
        public const string FolderFieldAssignTypeRegion = "region";
        public const string FolderFieldAssignTypeSubMarket = "submarket";
        public const string FolderFieldAssignTypeLabel = "label";
        public const string FolderFieldAssignTypeProductGroup = "productgroup";
        public const string FolderFieldAssignTypeProduct = "product";
        public const string FolderFieldAssignTypeTarget = "target";
        public const string FolderFieldAssignTypeDemand = "demand";
        public const string FolderFieldAssignTypeAction = "action";
        public const string FolderFieldAssignTypeGoal = "maingoal";
        public const string FolderFieldAssignTypeSubGoal = "subgoal";
        public const string FolderFieldAssignTypeMarketSegmentRegion = "marketsegmentregion";
        public const string FolderFieldAssignTypeSubMarketProduct = "submarketproduct";
        public const string FolderFieldAssignTypeCrmActivity = "crmactivity";
        public const string FolderFieldAssignTypeCrmOrganisation = "crmorganisation";
        public const string FolderFieldAssignTypeCrmPerson = "crmperson";
        public const string FolderFieldAssignTypeCrmLinkQuestion = "linkquestion";
        public const string FolderFieldAssignTypeCrmLinkAnswer = "linkanswer";
        public const string FolderFieldAssignTypeCrmThema = "crmthema";

        public const string ActExportName = "name";
        public const string ActExportBegin = "begin";
        public const string ActExportDue = "due";
        public const string ActExportPriority = "priority";
        public const string ActExportFinish = "finish";
        public const string ActExportResponsibility = "responsibility";
        public const string ActExportCategory = "category";
        public const string ActExportDescription = "description";
        public const string ActExportStatus = "status";
        public const string ActExportDate = "exportDate";
        public const string ActExportRelationship = "relasionship";

        public static readonly List<string> OrgSheetNames = new List<string> { "Organisation" };
        public static readonly List<string> ActSheetNames = new List<string> { "Activity", "Aktivität" };

        public static readonly List<string> OrgPrefixLang = new List<string> { "Organisation" };
        public static readonly List<string> PerPrefixLang = new List<string> { "Person", "Personen" };

        public static readonly string SourcingEmail = "Sourcing Email";

        public const string GreetingReminderEn = "Hello <v> <n>";
        public const string GreetingReminderDe = "Hallo <v> <n>";
        public const string SigningOffReminderEn = "Looking forward to our collaboration and regards <v> <n>";
        public const string SigningOffReminderDe = "Freue mich auf die Zusammenarbeit und Grüsse dich <v> <n>";

        public const string SubjectBirthDayReminderEn = "Birthday: ";
        public const string SubjectBirthDayReminderDe = "Geburtstag: ";

        public static readonly Dictionary<int, string> DefaultDFolders = new Dictionary<int, string>
        {
            {(int)DefaultDFolder.WORDTEMPLATE, "Word Vorlage" }, {(int)DefaultDFolder.FORMATDOCUMENT, "Dokumente Werbemittel" }
        };
        #region WORD TAG
        public const string ONAME_TAG = "<Oname>";
        public const string OSTREET_TAG = "<Ostraße>";
        public const string ONR_TAG = "<Onr>";
        public const string OADDITION_TAG = "<Oadresszusatz>";
        public const string OPLZ_TAG = "<OPLZ>";
        public const string OORT_TAG = "<Oort>";
        public const string OLAND_TAG = "<Oland>";
        public const string OKUNDEN_TAG = "<Okunden>";
        public const string OLEGANFORM_TAG = "<Orechtsform>";
        public const string OBRANCH_TAG = "<Obranche>";
        public const string OEMPLOYEE_TAG = "<Omitarbeiter>";
        public const string OACCOUNT_TAG = "<Overantwortung>";
        public const string OUMSATZ_TAG = "<OUmsatz>";

        public const string PSALUTATION_TAG = "<Panrede>";
        public const string PTITLE_TAG = "<Ptitel>";
        public const string PFIRSTNAME_TAG = "<Pvorname>";
        public const string PLASTNAME_TAG = "<Pnachname>";
        public const string PSTREET_TAG = "<Pstraße>";
        public const string PNR_TAG = "<Pnr>";
        public const string PADDITION_TAG = "<Padresszusatz>";
        public const string PPLZ_TAG = "<PPLZ>";
        public const string PORT_TAG = "<Port>";
        public const string PLAND_TAG = "<Pland>";
        public const string PEMAIL_TAG = "<Pmail>";
        public const string PORGANISATION_TAG = "<Porganisation>";
        public const string PPOSITION_TAG = "<Pposition>";
        public const string PNOTE_TAG = "<Pnotizen>";
        public const string PACCOUNT_TAG = "<PVerantwortung>";
        public const string PDEPARTMENT_TAG = "<PAbteilung>";

        public const string ANAME_TAG = "<Aaktivität>";
        public const string AACCOUNT_TAG = "<Averantwortung>";
        public const string ACATEGORY_TAG = "<Akategorie>";
        public const string APRIORITY_TAG = "<Apriorität>";
        public const string ASTARTDATE_TAG = "<Abeginn>";
        public const string ADUEDATE_TAG = "<Afällig>";
        public const string ADESCRIPTION_TAG = "<Abeschreibung>";
        public const string ACREATEDATE_TAG = "<Aerstellungsdatum>";
        public const string VORNAME_TAG = "<vorname>";
        public const string FIRSTNAME_TAG = "<firstname>";
        public const string NACHNAME_TAG = "<nachname>";
        public const string LASTNAME_TAG = "<lastname>";

        public const string FRAGEBOGENLINK_TAG = "<fragebogenlink>";
        public const string QUESTIONAIRE_TAG = "<questionairelink>";
        public const string FL_TAG = "<fl>";
        public const string QL_TAG = "<ql>";

        public const string FRAGEBOGENLINK_CLOSE_TAG = "</fragebogenlink>";
        public const string QUESTIONAIRE_CLOSE_TAG = "</questionairelink>";
        public const string FL_CLOSE_TAG = "</fl>";
        public const string QL_CLOSE_TAG = "</ql>";





        #endregion

        public static readonly Dictionary<string, string> MsCultures = new Dictionary<string, string>
        {
            {"en", "en-US" },
            {"de", "de-DE" },
            {"fr", "fr-FR" },
            {"it", "it-IT" }
        };

        public static readonly Dictionary<int, Func<decimal, bool>> KpiPercentTypes = new Dictionary<int, Func<decimal, bool>>
        {
            {(int)KpiPercentType.TO20, (decimal x)=> x <= 20 },
            {(int)KpiPercentType.FROM21TO40, (decimal x)=> x > 20 && x <= 40 },
            {(int)KpiPercentType.FROM41TO60, (decimal x)=> x > 40 && x <= 60 },
            {(int)KpiPercentType.FROM61TO80, (decimal x)=> x > 60 && x <= 80 },
            {(int)KpiPercentType.FROM81, (decimal x)=> x > 80 }
        };

        public const string DefaultCurrency = "VND";
        public const string DefaultExtensionValue = "1";
        public const string DefaultKeyCrypto = "Abc123";

        #region UserSoftwareReport
        public const string UserSoftwareReportPath = "/Markets/Charts/UserSoftwareReport.repx";
        public const string UserSoftwareParamLang = "Lang";
        #endregion

        public const string EmailSenderTimeWait = "EmailSenderTimeWaitSecond";
        public const string EmailSenderSessionFlag = "EmailSenderSessionFlag";

        public const string ColorB = "#4f61a4";
        public const string ColorO = "#598c59";
        public const string ColorP = "#EDD03F";
        public const string ColorC = "#c0b7a6";

        public class KpiTopicLanguage
        {
            public string Language { get; set; }

            public KpiTopicLanguage(string language)
            {
                Language = MsCultures.ContainsKey(language) ? language : "de";
            }

            public string GetDefaultTopicName(MsKpiGoalTopicType type)
            {
                var rs = string.Empty;
                switch (type)
                {
                    case MsKpiGoalTopicType.LANDREGION:

                        break;
                    case MsKpiGoalTopicType.MARKET:
                        rs = Language == "en" ? "Stakeholder groups" : "Anspruchsgruppen";
                        break;
                    case MsKpiGoalTopicType.PRODUCT:
                        rs = Language == "en" ? "Product" : "Produkt";
                        break;
                    case MsKpiGoalTopicType.GOAL:
                        rs = Language == "en" ? "Mastergoal" : "Masterziel";
                        break;
                    default:
                        break;
                }

                return rs;
            }
        }

        public static readonly List<string> ColorPaletteAction = new List<string> {
            "#1FD4AF", "#b84300", "#6b5800", "#004300", "#00555e", "#002f73", "#5421ab", "#5f3d1d", "#191919",
            "#DE7EB5", "#fd7400", "#c1aa03", "#0a7c00", "#009181", "#0046a8", "#9a22cc", "#905011", "#373737",
            "#EAE572", "#fb9f00", "#f2d500", "#b8c92e", "#00c2a7", "#256bd0", "#eb23af", "#a86925", "#5c5c5c",
            "#DE9C7E", "#ffd314", "#fff814", "#4dfd1a", "#4effea", "#65a0f4", "#ff68d3", "#de9038", "#9a9a9a",
            "#ffcab3", "#fff1b4", "#fffdcf", "#d1ff4b", "#c2fff2", "#a8cbff", "#ffb4fc", "#f8bb6c", "#dcdcdc"
        };

        public const string GoalActionColorDefault = "#b8c92e";
    }
}
