
namespace strategy.Common
{
    public enum MType
    {
        OLD = 2,
        NEW = 1
    }

    public enum MemberRole
    {
        NO_PROJECT = -2,
        NO_ROLE = -1,
        VIEW = 0,
        EDIT = 1,
        OWNER = 2
    }

    public enum TabRole
    {
        TAB_VIEW = 22,
        TAB_NOACCESS = 23
    }

    public enum CategoryType
    {
        CATEGORY_GOAL = 1,
        CATEGORY_ACTION = 2,
        GOAL_EVALUATION = 3,
        CURRENCY = 4,
        STRATEGY = 5,
        INSTRUMENT = 6,
        KPITIME = 18
    }

    public enum FilterType
    {
        SUBMARKET = 1,
        ACTION_PLAN = 2,
        MARKETTING_MIX = 3,
        PORTFOLIO = 4,
        DASHBOARD = 5, //tab6
        MARKETSEGMENT = 7,
        BUDGET = 8, //tab1
        ADVERTISINGMATERIAL = 9, //tab2
        MASTERGOAL = 10, //tab3
        CAMPAIGN = 11, //tab4,
        PRODUCTANDSTAKEHOLDERGROUP = 12, //tab5
        TEAMBOARD = 13,
        ROADMAP = 14
    }

    public enum FilterDataType
    {
        PRODUCT = 1,
        MARKET = 2
    };

    public enum FilterMarketType
    {
        LAND = 1,
        MARKET = 2
    };

    public enum RoleId
    {
        GROUP_OWNER = 1,
        GROUP_EDIT = 2,
        GROUP_VIEW = 3,
        PROJECT_OWNER = 4,
        PROJECT_EDIT = 5,
        PROJECT_VIEW = 6,
        STRATEGY_EDIT = 7,
        STRATEGY_VIEW = 8,
        GROUP_DEFAULD_VIEW = 13,
        LAND_EDIT = 14,
        LAND_VIEW = 16,
        REGION_EDIT = 15,
        REGION_VIEW = 17,
        LAND_NO_ACCESS = 19,
        REGION_NO_ACCESS = 20,
        EMPTY = 21 // inherit from parent
    }

    public enum ResultData
    {
        NAMEDUPLICATE = 1,
        NOTHING = -1,
        CONFLICT = -3,
        SENT_MAIL_ERROR = -5,
        NO_ROLE = -6
    }

    public enum ResultSetting
    {
        Exits = -3,
        Using = -2
    }

    public enum ResultStatus
    {
        EmailDuplicate,
        Conflict,
        ProjectDeleted,
        NoConflict,
        UpdateSuccess,
        NotFound
    }

    public enum OrgValidStatus
    {
        Duplicate = -1,
        DuplicateMarket = -2,
        Ok = 1
    }

    public enum ExportTitleKey
    {
        PERSONCATEGORY = 31,
        KUNDENNR = -1, //newx
        NAME = 0,
        ADDRESS,
        PHONE,
        FAX,
        MAIL,
        WEBSITE,
        NETWORK,
        RESOURCE,
        COMPETENCE,
        CATEGORY,
        LEGALFORM,
        BRANCH,
        EMPLOYEE,
        NOTE,
        TAG,
        SALUTATION,
        TITLE,
        FIRSTNAME,
        LASTNAME,
        POSITION,
        ID,
        LAND,
        RELATIONSHIP,
        RESPONSIBILITY,
        REVENUE
    }

    public enum ExportTitleKeySub
    {
        KUNDENNR = 0, //newx
        ORGNAME = 1,
        ADDRESS,
        STREET,
        NO,
        ADDITION,
        ZIPCODE,
        PLACE,
        COUNTRY,
        LEGALFORM,
        BRANCH,
        EMPLOYEE,
        TAG,
        NOTE,
        SALUTATION,
        TITLE,
        FIRSTNAME,
        LASTNAME,
        POSITION,
        ORGID,
        PERID,
        RELATIONSHIP,
        RESPONSIBILITY,
        REVENUE,
        DEPARTMENT,
        ISACTIVEPOSITION
    }

    public enum ExportAddressKey
    {
        CATEGORY = 1,
        STREET,
        NR,
        PLZ,
        ORT,
        LAND
    }

    public enum ExportTitleKeyAct
    {
        NAME = 0,
        BEGIN,
        DUE,
        PRIORITY,
        FINISH,
        RESPONSIBILITY,
        CATEGORY,
        DESCRIPTION,
        STATUS,
        RELATIONSHIP
    }

    public enum CrmOrganisationSetting
    {
        ADDRESS = 1,
        TELEPHONE = 2,
        FAX = 3,
        EMAIL = 4,
        WEBSITE = 5,
        NETWORK = 6,
        RESOURCE = 7,
        COMPETENCE = 8,
        CATEGORY = 9,
        LEGAL_FORM = 10,
        EMPLOYEE = 11,
        BRANCH = 12,
        TAGS = 13,
        LAND = 14,
        NAME = 15,
        STREET = 16,
        NR = 17,
        PLZ = 18,
        ORT = 19,
        NOTE = 20,
        KUNDENNR = 21,
        RELATIONSHIP = 22,
        ADDITIONADDRESS = 27,
        RESPONSIBILITY = 23,
        REVENUE = 24
    }

    public enum CrmPersonSetting
    {
        ADDRESS = 1,
        TELEPHONE = 2,
        FAX = 3,
        EMAIL = 4,
        WEBSITE = 5,
        NETWORK = 6,
        RESOURCE = 7,
        COMPETENCE = 8,
        BRANCH = 9,
        TAGS = 10,
        POSITION = 11,
        RELATIONSHIP = 12,
        LAND = 14,
        NAME = 15,
        STREET = 16,
        NR = 17,
        PLZ = 18,
        ORT = 19,
        NOTE = 20,
        FIRSTNAME = 21,
        LASTNAME = 22,
        ORGANISATON = 23,
        SALUTATION = 24,
        TITTLE = 25,
        RESPONSIBILITY = 26,
        ADDITIONADDRESS = 27,
        BIRTHDAY = 30,
        CATEGORY = 31
    }

    //SONPT

    public enum CrmQuestionTypes
    {
        RatingScale = 1,
        SimpleChoice = 2,
        SimpleDrop = 3,
        MultipleChoice = 4,
        ForcedChoiceItem = 5,
        ForcedDropItem = 6,
        SinglelineText = 7,
        MultilineText = 8,
        Image = 9,
        Data = 10,
        Ntext = 11,
        SimpleChoiceWithImage = 12,
        MultipleChoiceWithImage = 13,
        ModuleText = 14,
        Document = 15,
        Article = 16
    }

    public enum CrmLinkQuestionTypes
    {
        Nothing = 0,
        Hideall = -1
    }

    public enum CrmMainTittle
    {
        Nothing = 0,
        GroupTittle = 1
    }

    public enum CrmActivitieSetting
    {
        CATEGORY = 1,
        PRIORITY = 2,
        RELATIONSHIP = 3,
        STATUS = 4,
        CREATEDATE = 5,
        NAMEOFORG = 6,
        NAMEOFPERSON = 7,
        RESPONSIBILITY = 8,
        BEGINDATE = 9,
        DUEDATE = 10,
        FINISH = 11,
        ROLLE = 12,
        LASTSTATUS = 13,
        NEW = 14
    }

    public enum SettingType
    {
        MARKETING = 1,
        ORGANISATION = 2,
        PERSON = 3,
        ACTIVITY = 4,
        CROWD = 5
    }

    public enum ActivityType
    {
        ACTIVITYPERSON = 1,
        ACTIVITYORGANISATION = 2
    }

    public enum RelationshipType
    {
        PERSON = 1,
        ORGANISATION = 2
    }

    //Refferences with Type in Categories Table.
    public enum MarketingSetting
    {
        GOAL = 1,
        ACTION = 2,
        EVALUATION = 3,
        CURRENCY = 4,
        STRATEGY = 5,
        INSTRUMENT = 6,
        ACTION_FIELD = 7,
        PROTOCOL_STATUS = 8,
        AdvertisingMaterials = 10,
        Advertisers = 11,
        SubjetThema = 15,
        Supplier = 14,
        KpiUnit = 17,
        KpiTime = 18,
        Product = 21,
        Submarket = 22,
        Journey = 23, // Customer journey
        SharepointLinkControl = 24
    }

    public enum LinkSharepointType
    {
        ROADMAP = 1,
        MIX = 2
    }

    public enum CrmOperator
    {
        AND = 1,
        OR = 2,
        FILTERBY = 3
    }

    /// <summary>
    /// Data mapping from table CodeLastAction in database
    /// </summary>
    public enum ECodeLastAction
    {
        PROJECT_MODULE = 1,
        FILTER_ORGANISATION = 2,
        FILTER_PERSON = 3,
        FILTER_ACTIVITY = 4,
        SORT_PERSON_FIELD = 5,
        SORT_PERSON_TYPE = 6,
        FILTER_CROWD = 7,
        SORT_ACTIVITY_FIELD = 8,
        SORT_ACTIVITY_TYPE = 9,
        SETTING_PREVIEW_MARKETING = 10,
        LAST_STRATEGY = 11,
        SHOW_ACTIVITY_PAGE = 12,
        SHOW_ACTIVITY_CRM = 13,
        SORT_ACTIVITY_SUB_FIELD = 14,
        SORT_ACTIVITY_SUB_TYPE = 15,
        SORT_CROWD_FIELD = 16,
        SORT_CROWD_TYPE = 17,
        SHOW_CROWD_CRM = 18,
        SHOW_ALL_CROW = 19,
        SHOW_ALL_PERSON = 20,
        LAST_ACTIONPLAN_EDIT = 21,
        FILTER_DASHBOARD = 22,
        LAST_LAND_ID = 23,
        LAST_PRODUCTGROUP_ID = 24,
        LAST_LAN_ID = 25,
        ROAD_MAP = 26,
        SETTING_PREVIEW_ROADMAP = 27
    }

    public enum TemplateType
    {
        ProductEvaluation,
        ProductCompetition,
        ProductPosition,
        MarketSegmentReview, //Region Evaluation Template
        ProductDesign,
        Swotanalyse,
        SubmarketProduct,
        MainGoal,
        SubGoal,
        Action,
        ActionPlanEvaluation,
        ActionPlanProductDesign,
        ApEvaluationTemplate,
        ApProductTemplate,
        ApSwotanalyseTemplate
    }


    public enum TypeConnection
    {
        ACTION_SUBMARKET = 1,
        ACTION_PRODUCT = 2,
        GOAL_SUBMARKET = 3,
        GOAL_PRODUCT = 4
    }

    public enum ExportChildType
    {
        Thema = 1,
        Group = 2,
        Title = 3,
        Question = 4,
        Answer = 5,
        SubQuestion = 6
    }

    public enum ObjectAttachType
    {
        CrowdProject = 1
    }

    public enum SaveState
    {
        UnSaved = -1,
        Saved = 0
    }

    public enum SENDEMAILTO
    {
        ALL = 2,
        NOTSTARTED = 1,
        NOTFINISHED = 0
    }

    public enum EmailType
    {
        Cc = 1,
        Bcc = 2
    }

    public enum GoalActionContentType
    {
        Other = 0,
        MainGoal = 1,
        SubGoal = 2,
        Action = 3
    }
    // ReSharper restore InconsistentNaming

    public enum DashBoardPositionType
    {
        DashBoard = 1,
        MarketingMix = 2
    }

    public enum MsFilterType
    {
        RedirectGoal = 25
    }


    public enum SortActivityField
    {
        Name = 0,
        StartDate = 1,
        DueDate = 2,
        Organisation = 3,
        CreateDate = 5

    }

    public enum SortCrowdField
    {
        Start = 0,
        End = 1,
        Name = 2
    }

    public enum SortPersonField
    {
        FirstName = 0,
        LastName = 1
    }

    public enum FilterDates
    {
        Overdue = 1,
        DueToday = 2,
        NextTenDays = 3,
        OverTenDays = 4,
        StillOpen = 5,
        AlreadyFisnished = 6
    }

    public enum StrategyType
    {
        MARKETING = 1,
        CRM = 2
    }

    public enum ImportResult
    {
        INVALID = -1,
        NOTHING = 0,
        SUCCESS = 1
    }

    public enum ReminderType
    {
        GOAL = 1,
        ACTION = 2,
        ACTIVITY = 3,
        PERSON = 4,
        ACTIONTODO = 5
    }

    public enum ActionPersonType
    {
        NormalPerson = 1,
        InvolvedPerson = 2
    }

    public enum ActionPlanSubClientType
    {
        MarketSegment = 1,
        SubMarket = 2,
        SubClient = 3
    }

    public enum CustomerJourneyType
    {
        JourneyGroup = 1,
        Journey = 2,
        SubJourney = 3
    }

    public enum FileType
    {
        Folder = 0,
        NonType = 3,
        Pdf = 4,
        Word = 5,
        Excel = 6,
        Image = 7,
        Url = 8,
        Ppt = 9,
        Visio = 10,
        Path = 11
    }

    public enum CrmCrowdStatusTagEnum
    {
        NotIsAccess = 5,
        IsReadMail = 6,
        TagsTo10 = 7,
        TagsTo30 = 8,
        TagsTo65 = 9,
        TagsTo85 = 10,
        TagsTo100 = 11
    }

    public enum ExpandType
    {
        MarketSegment = 1,
        ProductGroup = 2
    }

    public enum DefaultDFolder
    {
        WORDTEMPLATE = 1,
        FORMATDOCUMENT = 2
    }

    public enum CrmCategoriesExtensionType
    {
        CROWDPROJECT = 1,
        WORD = 2,
        STATUSCHECK = 3
    }

    public enum CompareDateType
    {
        EARLIER = -1,
        SAME = 0,
        LATER = 1
    }

    //newx
    public enum OrganisationValidType
    {
        DUPLICATE_NAME = -2,
        DUPLICATE_KUNDENNR = -1,
        SUCCESS = 1
    }

    public enum CrmQuestionStatus
    {
        IsNotEdited = 0,
        IsEdited = 1
    }

    public enum MsKpiGoalTopicType
    {
        LANDREGION = 1,
        MARKET = 2,
        PRODUCT = 3,
        GOAL = 4
    }

    public enum MsKpiGoalIndexType
    {
        LAND = 1,
        REGION = 2,
        MARKET = 3,
        SUBMARKET = 4,
        SUBCLIENT = 5,
        GROUP = 6,
        PRODUCT = 7,
        SUBPRODUCT = 8,
        MAINGOAL = 9,
        SUBGOAL = 10
    }

    public enum KpiGoalIndexType
    {
        Land = 1,
        Region = 2,
        MarketSegment = 3,
        Submarket = 4,
        Subclient = 5,
        ProductGroup = 6,
        Product = 7,
        SubProduct = 8,
        Maingoal = 9,
        Subgoal = 10
    }

    public enum KpiGoalTopicType
    {
        LandRegion = 1,
        Market = 2,
        Product = 3,
        Goal = 4
    }

    public enum KpiUnitType
    {
        Number = 1,
        Currency = 2,
        Percent = 3,
        Index = 4,
        M2 = 5,
        Hour = 6
    }

    public enum KpiUnitPosition
    {
        Links = 1,
        Rechts = 2,
        Mitte = 3
    }

    public enum KpiUnitOrder
    {
        Vorn = 1,
        Hinter = 2
    }

    public enum FormatType
    {
        Format = 1,
        Cost = 2,
        Description = 3,
        CrmLink = 4,
        Document = 5
    }

    public enum FormatItemType
    {
        ORGANISATION = 1,
        PERSON = 2,
        FILE = 3
    }

    public enum KpiPercentType
    {
        TO20,
        FROM21TO40,
        FROM41TO60,
        FROM61TO80,
        FROM81
    }

    public enum ActivityReadStatus
    {
        Unread = 1,
        Read = 2
    }


    public enum ReportIds
    {
        Karriereanker = 6,
        UserSoftware = 11
    }

    public enum ReportFileAssignType
    {
        AutoPDF = 1,
        UserSoftware = 2
    }

    public enum SubmarketProductSeLevel
    {
        ProductGroupOrMarketSegment = 1,
        ProductOrSubmarket = 2,
        SubProductOrSubClient = 3
    }

    public enum ActionCustomViewType
    {
        INDIVIDUAL = 0,

        MASTERBUGET = 1,
        PRODUCT = 2,
        MARKET = 3,
        CUSTOMERJOURNEY = 19,
        DESCRIPTION = 4,
        EXPECTEDEFFECT = 5,
        ACTUALEFFECT = 6,
        RESPONSIBILITY = 7,
        INVOLVEDPEOPLE = 8,
        CATEGORY = 9,
        FIELD = 10,
        ADVERTISING = 11,
        ADVERTISER = 12,
        SUBJECTTHEMA = 13,
        REGION = 14,
        COST = 15,
        UPSTREAM = 16,
        RESOURCEPLANNING = 17,
        VISIBILITY = 18
    }

    public enum SynchronizedViewType
    {
        LOAD,
        SAVE
    }

    public enum FilterControlTypes
    {
        Land = 1,
        Region = 2,
        ProductGroup = 3,
        Product = 4,
        Market = 5,
        Submarket = 6,
        Person = 7,
        Type = 8,
        Goal = 9,
        Date = 10,
        Action = 11,
        ProtocolStatus = 12,
        Visibility = 13,
        Field = 14,
        Independency = 15,
        Theme = 16,
        Instrument = 17,
        AdvertisingMaterial = 18,
        Advertiser = 19,
        TimeRange = 20,
        MasterGoal = 21,
        FibuItems = 22,
        LandRegion = 23,
        WorkingRange = 24,
        RedirectGoal = 25,
        TextSearch = 26,
        SubjetThema = 27,
        Supplier = 28,
        MasterGoalKpi = 29,
        MarketScope = 30,
        LastProtocolStatus = 31,
        CustomerJourney = 32,
        ShowFinishedElements = 33
    }

    public enum FilterTypeX
    {
        OnlyGoal = 1,
        OnlyAction = 2,
        BothGoalAction = 3
    }

    public enum ProductSubmarketType
    {
        ProductSe = 1,
        SubmarketSe = 2,
        Product = 3,
        Submarket = 4
    }

    public enum AssignSettingType
    {
        ProductGroup = 1,
        Product = 2,
        SubProduct = 3,
        Submarket = 4,
        Subclient = 5
    }

    public enum AssignType
    {
        Product = 1,
        SubMarket = 2
    }

    public enum RegionTitleType
    {
        ProductGroup = 1,
        SubMarket = 2,
        SubmMarketProduct = 3
    }

    public enum ActionStatus
    {
        ActionDeleted,
        Error,
        UpdateSuccess,
        Conflict,
        NoConflict
    }

    public enum VisibilityType
    {
        HideElement = 0,
        ShowAll = 1,
        ShowOnlyHiden = 2
    }

    public enum OverWriteType
    {
        NORMAL = 0,
        OVERWRITE = 1,
        ADDALLDATA = 2
    }

    public enum ItemFilterType
    {
        Land = 1,
        Region = 2,
        Market = 3,
        Submarket = 4,
        Subclient = 5,
        ProductGroup = 6,
        Product = 7,
        SubProduct = 8,
        MarketSe = 9,
        SubMarketSe = 10,
        SubClientSe = 11,
        Person = 12,
        Field = 13,
        Status = 14,
        LastStatus = 15,
        Todo = 16,
        Instrument = 17,
        Advertising = 18,
        Advertiser = 19,
        SuperiorTheme = 20,
        Theme = 21,
        GoalCategory = 22,
        ActionCategory = 23,
        Type = 24,
        Visibility = 25,
        SubjectThema = 26,
        Supplier = 27,
        MainMasterGoal = 28,
        SubMasterGoal = 29,
        MainMasterBudget = 30,
        SubMasterBudget = 31,
        LandRegionFibu = 32,
        AccountFibu = 33,
        CostCenterFibu = 34
    };

    public enum MarketsegmentTitleType
    {
        Marketsegment = 1, Land = 2, HeaderMarketsegment = 3
    }

    public enum PersonExportType
    {
        NORMAL = 0,
        QUESTIONLINK = 1
    }

    public enum BoardColumnFilterType
    {
        Filter = 1,
        Subordinate = 2,
    }

    public enum BoardColumnSortType
    {
        DueDate = 1,
        Index = 2,
        Evaluation = 3
    }


    public enum MTabType
    {
        Market = 1,
        SubMarket = 2,
        ActionPlan = 3,
        Marketingmix = 4,
        Teamboard = 5,
        Dashboard = 6
    }
}
