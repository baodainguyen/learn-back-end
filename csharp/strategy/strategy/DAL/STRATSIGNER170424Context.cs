using System;
using Microsoft.EntityFrameworkCore;
using strategy.Models;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace strategy.DAL
{
    public partial class STRATSIGNER170424Context : DbContext
    {
        public STRATSIGNER170424Context()
        {
        }

        public STRATSIGNER170424Context(DbContextOptions<STRATSIGNER170424Context> options)
            : base(options)
        {
        }

        #region Dbset
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCrmRole> AccountCrmRoles { get; set; }
        public virtual DbSet<AccountLastAction> AccountLastActions { get; set; }
        public virtual DbSet<AccountRole> AccountRoles { get; set; }
        public virtual DbSet<Models.Action> Actions { get; set; }
        public virtual DbSet<ActionCategory> ActionCategories { get; set; }
        public virtual DbSet<ActionCategoryTemp> ActionCategoryTemps { get; set; }
        public virtual DbSet<ActionCost> ActionCosts { get; set; }
        public virtual DbSet<ActionCostTemp> ActionCostTemps { get; set; }
        public virtual DbSet<ActionCustomView> ActionCustomViews { get; set; }
        public virtual DbSet<ActionCustomViewCategory> ActionCustomViewCategories { get; set; }
        public virtual DbSet<ActionDate> ActionDates { get; set; }
        public virtual DbSet<ActionFibu> ActionFibus { get; set; }
        public virtual DbSet<ActionFibuTemp> ActionFibuTemps { get; set; }
        public virtual DbSet<ActionFormat> ActionFormats { get; set; }
        public virtual DbSet<ActionFormatTemp> ActionFormatTemps { get; set; }
        public virtual DbSet<ActionPerson> ActionPeople { get; set; }
        public virtual DbSet<ActionPersonTemp> ActionPersonTemps { get; set; }
        public virtual DbSet<ActionPlanColumn> ActionPlanColumns { get; set; }
        public virtual DbSet<ActionPlanColumnTemp> ActionPlanColumnTemps { get; set; }
        public virtual DbSet<ActionPlanConnection> ActionPlanConnections { get; set; }
        public virtual DbSet<ActionPlanCustomerJourney> ActionPlanCustomerJourneys { get; set; }
        public virtual DbSet<ActionPlanCustomerJourneyTemp> ActionPlanCustomerJourneyTemps { get; set; }
        public virtual DbSet<ActionPlanExpand> ActionPlanExpands { get; set; }
        public virtual DbSet<ActionPlanLink> ActionPlanLinks { get; set; }
        public virtual DbSet<ActionPlanRegion> ActionPlanRegions { get; set; }
        public virtual DbSet<ActionPlanRegionTemp> ActionPlanRegionTemps { get; set; }
        public virtual DbSet<ActionPlanReminder> ActionPlanReminders { get; set; }
        public virtual DbSet<ActionPlanSubClient> ActionPlanSubClients { get; set; }
        public virtual DbSet<ActionPlanSubClientTemp> ActionPlanSubClientTemps { get; set; }
        public virtual DbSet<ActionPlanSubProduct> ActionPlanSubProducts { get; set; }
        public virtual DbSet<ActionPlanSubProductTemp> ActionPlanSubProductTemps { get; set; }
        public virtual DbSet<ActionReminderView> ActionReminderViews { get; set; }
        public virtual DbSet<ActionTemp> ActionTemps { get; set; }
        public virtual DbSet<ActionTitleLang> ActionTitleLangs { get; set; }
        public virtual DbSet<ActionTodo> ActionTodos { get; set; }
        public virtual DbSet<ActionTodoDepartment> ActionTodoDepartments { get; set; }
        public virtual DbSet<ActionTodoDiscussion> ActionTodoDiscussions { get; set; }
        public virtual DbSet<ActionTodoNotify> ActionTodoNotifies { get; set; }
        public virtual DbSet<ActionTodoPerson> ActionTodoPeople { get; set; }
        public virtual DbSet<ActionTodoPersonTemp> ActionTodoPersonTemps { get; set; }
        public virtual DbSet<ActionTodoTemp> ActionTodoTemps { get; set; }
        public virtual DbSet<ActionUpStreamConnection> ActionUpStreamConnections { get; set; }
        public virtual DbSet<ApDemand> ApDemands { get; set; }
        public virtual DbSet<ApDemandChart> ApDemandCharts { get; set; }
        public virtual DbSet<ApDemandChartEvaluation> ApDemandChartEvaluations { get; set; }
        public virtual DbSet<ApDemandChartEvaluationTemp> ApDemandChartEvaluationTemps { get; set; }
        public virtual DbSet<ApDemandChartTemp> ApDemandChartTemps { get; set; }
        public virtual DbSet<ApDemandTemp> ApDemandTemps { get; set; }
        public virtual DbSet<ApEvaluation> ApEvaluations { get; set; }
        public virtual DbSet<ApEvaluationTemp> ApEvaluationTemps { get; set; }
        public virtual DbSet<ApSubSwotanalyse> ApSubSwotanalyses { get; set; }
        public virtual DbSet<ApSubSwotanalyseTemp> ApSubSwotanalyseTemps { get; set; }
        public virtual DbSet<ApSwotanalyse> ApSwotanalyses { get; set; }
        public virtual DbSet<ApSwotanalyseTemp> ApSwotanalyseTemps { get; set; }
        public virtual DbSet<ApTargetGroup> ApTargetGroups { get; set; }
        public virtual DbSet<ApTargetGroupTemp> ApTargetGroupTemps { get; set; }
        public virtual DbSet<AssignSetting> AssignSettings { get; set; }
        public virtual DbSet<AttachFile> AttachFiles { get; set; }
        public virtual DbSet<BoardColumn> BoardColumns { get; set; }
        public virtual DbSet<BoardColumnActionPlan> BoardColumnActionPlans { get; set; }
        public virtual DbSet<BoardExpand> BoardExpands { get; set; }
        public virtual DbSet<BoardFilter> BoardFilters { get; set; }
        public virtual DbSet<BoardFilterSubordinate> BoardFilterSubordinates { get; set; }
        public virtual DbSet<BoardLine> BoardLines { get; set; }
        public virtual DbSet<BoardLineExpand> BoardLineExpands { get; set; }
        public virtual DbSet<BoardName> BoardNames { get; set; }
        public virtual DbSet<BoardNamePerson> BoardNamePeople { get; set; }
        public virtual DbSet<CategoriesLanguage> CategoriesLanguages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CodeLastAction> CodeLastActions { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<CrmAccountSmtp> CrmAccountSmtps { get; set; }
        public virtual DbSet<CrmActivity> CrmActivities { get; set; }
        public virtual DbSet<CrmActivityAccountView> CrmActivityAccountViews { get; set; }
        public virtual DbSet<CrmActivityCategory> CrmActivityCategories { get; set; }
        public virtual DbSet<CrmActivityCategoryViewForFilter> CrmActivityCategoryViewForFilters { get; set; }
        public virtual DbSet<CrmActivityPerson> CrmActivityPeople { get; set; }
        public virtual DbSet<CrmActivityPersonNameOneOrgTopView> CrmActivityPersonNameOneOrgTopViews { get; set; }
        public virtual DbSet<CrmActivityPersonNameView> CrmActivityPersonNameViews { get; set; }
        public virtual DbSet<CrmActivityPersonViewForFilter> CrmActivityPersonViewForFilters { get; set; }
        public virtual DbSet<CrmActivityRelationView> CrmActivityRelationViews { get; set; }
        public virtual DbSet<CrmActivityRelationship> CrmActivityRelationships { get; set; }
        public virtual DbSet<CrmActivityView> CrmActivityViews { get; set; }
        public virtual DbSet<CrmActivityViewActivity> CrmActivityViewActivities { get; set; }
        public virtual DbSet<CrmAddress> CrmAddresses { get; set; }
        public virtual DbSet<CrmAddressView> CrmAddressViews { get; set; }
        public virtual DbSet<CrmAnswer> CrmAnswers { get; set; }
        public virtual DbSet<CrmAnswerOption> CrmAnswerOptions { get; set; }
        public virtual DbSet<CrmAnswerPerson> CrmAnswerPeople { get; set; }
        public virtual DbSet<CrmCategoriesExtension> CrmCategoriesExtensions { get; set; }
        public virtual DbSet<CrmCategoriesTest> CrmCategoriesTests { get; set; }
        public virtual DbSet<CrmCategory> CrmCategories { get; set; }
        public virtual DbSet<CrmCrowdProject> CrmCrowdProjects { get; set; }
        public virtual DbSet<CrmCrowdProjectCc> CrmCrowdProjectCcs { get; set; }
        public virtual DbSet<CrmCrowdProjectGroup> CrmCrowdProjectGroups { get; set; }
        public virtual DbSet<CrmCrowdProjectMonitor> CrmCrowdProjectMonitors { get; set; }
        public virtual DbSet<CrmCrowdProjectPerson> CrmCrowdProjectPeople { get; set; }
        public virtual DbSet<CrmFilter> CrmFilters { get; set; }
        public virtual DbSet<CrmFiltersCrowd> CrmFiltersCrowds { get; set; }
        public virtual DbSet<CrmFragenset> CrmFragensets { get; set; }
        public virtual DbSet<CrmFragensetGroup> CrmFragensetGroups { get; set; }
        public virtual DbSet<CrmGroupQuestionReportView> CrmGroupQuestionReportViews { get; set; }
        public virtual DbSet<CrmImportTemp> CrmImportTemps { get; set; }
        public virtual DbSet<CrmInformation> CrmInformations { get; set; }
        public virtual DbSet<CrmInformationFilterView> CrmInformationFilterViews { get; set; }
        public virtual DbSet<CrmInformationView> CrmInformationViews { get; set; }
        public virtual DbSet<CrmLanFilter> CrmLanFilters { get; set; }
        public virtual DbSet<CrmLinkQuestion> CrmLinkQuestions { get; set; }
        public virtual DbSet<CrmOrganisation> CrmOrganisations { get; set; }
        public virtual DbSet<CrmOrganisationRelationView> CrmOrganisationRelationViews { get; set; }
        public virtual DbSet<CrmOrganisationRelationship> CrmOrganisationRelationships { get; set; }
        public virtual DbSet<CrmOrganisationResponsibility> CrmOrganisationResponsibilities { get; set; }
        public virtual DbSet<CrmOrganisationResponsibilityForFilter> CrmOrganisationResponsibilityForFilters { get; set; }
        public virtual DbSet<CrmOrganisationResponsibilityView> CrmOrganisationResponsibilityViews { get; set; }
        public virtual DbSet<CrmOrganisationView> CrmOrganisationViews { get; set; }
        public virtual DbSet<CrmOrganisationViewForFilterByActivityId> CrmOrganisationViewForFilterByActivityIds { get; set; }
        public virtual DbSet<CrmOrganisationViewOrganisation> CrmOrganisationViewOrganisations { get; set; }
        public virtual DbSet<CrmOrganisationWithDueDateView> CrmOrganisationWithDueDateViews { get; set; }
        public virtual DbSet<CrmOrganisationWithPersonView> CrmOrganisationWithPersonViews { get; set; }
        public virtual DbSet<CrmPerson> CrmPeople { get; set; }
        public virtual DbSet<CrmPersonHost> CrmPersonHosts { get; set; }
        public virtual DbSet<CrmPersonPositionView> CrmPersonPositionViews { get; set; }
        public virtual DbSet<CrmPersonRelationView> CrmPersonRelationViews { get; set; }
        public virtual DbSet<CrmPersonRelationship> CrmPersonRelationships { get; set; }
        public virtual DbSet<CrmPersonReminder> CrmPersonReminders { get; set; }
        public virtual DbSet<CrmPersonResponsibility> CrmPersonResponsibilities { get; set; }
        public virtual DbSet<CrmPersonResponsibilityForFilter> CrmPersonResponsibilityForFilters { get; set; }
        public virtual DbSet<CrmPersonResponsibilityView> CrmPersonResponsibilityViews { get; set; }
        public virtual DbSet<CrmPersonView> CrmPersonViews { get; set; }
        public virtual DbSet<CrmPersonViewCrowd> CrmPersonViewCrowds { get; set; }
        public virtual DbSet<CrmPersonViewForFilterByActivityId> CrmPersonViewForFilterByActivityIds { get; set; }
        public virtual DbSet<CrmPersonViewOrganisation> CrmPersonViewOrganisations { get; set; }
        public virtual DbSet<CrmPersonWithDueDateView> CrmPersonWithDueDateViews { get; set; }
        public virtual DbSet<CrmPosition> CrmPositions { get; set; }
        public virtual DbSet<CrmPositionMaxMindexView> CrmPositionMaxMindexViews { get; set; }
        public virtual DbSet<CrmPositionView> CrmPositionViews { get; set; }
        public virtual DbSet<CrmQuestion> CrmQuestions { get; set; }
        public virtual DbSet<CrmQuestionAnswerScaleGroupQuestionView> CrmQuestionAnswerScaleGroupQuestionViews { get; set; }
        public virtual DbSet<CrmQuestionAnswerScaleThemaView> CrmQuestionAnswerScaleThemaViews { get; set; }
        public virtual DbSet<CrmQuestionCountView> CrmQuestionCountViews { get; set; }
        public virtual DbSet<CrmQuestionGroup> CrmQuestionGroups { get; set; }
        public virtual DbSet<CrmQuestionPerson> CrmQuestionPeople { get; set; }
        public virtual DbSet<CrmQuestionPersonCountView> CrmQuestionPersonCountViews { get; set; }
        public virtual DbSet<CrmSourcingEmailView> CrmSourcingEmailViews { get; set; }
        public virtual DbSet<CrmStatusProtocol> CrmStatusProtocols { get; set; }
        public virtual DbSet<CrmStatusProtocolQuestionnaire> CrmStatusProtocolQuestionnaires { get; set; }
        public virtual DbSet<CrmStatusProtocolView> CrmStatusProtocolViews { get; set; }
        public virtual DbSet<CrmStatusProtocolViewForFilterByActivity> CrmStatusProtocolViewForFilterByActivities { get; set; }
        public virtual DbSet<CrmStatusProtocolViewLastStatus> CrmStatusProtocolViewLastStatuses { get; set; }
        public virtual DbSet<CrmTag> CrmTags { get; set; }
        public virtual DbSet<CrmTagCrowd> CrmTagCrowds { get; set; }
        public virtual DbSet<CrmTagMapping> CrmTagMappings { get; set; }
        public virtual DbSet<CrmTagView> CrmTagViews { get; set; }
        public virtual DbSet<CrmThema> CrmThemas { get; set; }
        public virtual DbSet<CrmToken> CrmTokens { get; set; }
        public virtual DbSet<CustomerJourney> CustomerJourneys { get; set; }
        public virtual DbSet<DashboardAccount> DashboardAccounts { get; set; }
        public virtual DbSet<DashboardConfig> DashboardConfigs { get; set; }
        public virtual DbSet<DashboardPositionAccount> DashboardPositionAccounts { get; set; }
        public virtual DbSet<Demand> Demands { get; set; }
        public virtual DbSet<DemandChart> DemandCharts { get; set; }
        public virtual DbSet<DemandChartEvaluation> DemandChartEvaluations { get; set; }
        public virtual DbSet<DemandChartEvaluationTemp> DemandChartEvaluationTemps { get; set; }
        public virtual DbSet<DemandChartTemp> DemandChartTemps { get; set; }
        public virtual DbSet<DemandTemp> DemandTemps { get; set; }
        public virtual DbSet<DepartmentAccount> DepartmentAccounts { get; set; }
        public virtual DbSet<DepartmentRole> DepartmentRoles { get; set; }
        public virtual DbSet<DocumentSe> DocumentSes { get; set; }
        public virtual DbSet<FibuKonten> FibuKontens { get; set; }
        public virtual DbSet<FibuLandRegion> FibuLandRegions { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<FolderFieldAssign> FolderFieldAssigns { get; set; }
        public virtual DbSet<FolderFieldAssignTemp> FolderFieldAssignTemps { get; set; }
        public virtual DbSet<FolderFile> FolderFiles { get; set; }
        public virtual DbSet<FolderFileAssignReport> FolderFileAssignReports { get; set; }
        public virtual DbSet<FolderFileView> FolderFileViews { get; set; }
        public virtual DbSet<GetActualCostByMainGoalIdView> GetActualCostByMainGoalIdViews { get; set; }
        public virtual DbSet<GetActualCostByMainGoalIdViewForCalendar> GetActualCostByMainGoalIdViewForCalendars { get; set; }
        public virtual DbSet<GetActualCostBySubGoalView> GetActualCostBySubGoalViews { get; set; }
        public virtual DbSet<GetActualCostBySubGoalViewForCalendar> GetActualCostBySubGoalViewForCalendars { get; set; }
        public virtual DbSet<GetAllGoalActionDashboardView> GetAllGoalActionDashboardViews { get; set; }
        public virtual DbSet<GetAvgSubmarket> GetAvgSubmarkets { get; set; }
        public virtual DbSet<GetExpectedCostByMainGoalView> GetExpectedCostByMainGoalViews { get; set; }
        public virtual DbSet<GetExpectedCostByMainGoalViewForCalendar> GetExpectedCostByMainGoalViewForCalendars { get; set; }
        public virtual DbSet<GetExpectedCostBySubGoalView> GetExpectedCostBySubGoalViews { get; set; }
        public virtual DbSet<GetExpectedCostBySubGoalViewForCalendar> GetExpectedCostBySubGoalViewForCalendars { get; set; }
        public virtual DbSet<GetMarketSegmentRegionCost> GetMarketSegmentRegionCosts { get; set; }
        public virtual DbSet<GetProductFinanceCost> GetProductFinanceCosts { get; set; }
        public virtual DbSet<GetRegionCurrency> GetRegionCurrencies { get; set; }
        public virtual DbSet<GetSubMarketProductCost> GetSubMarketProductCosts { get; set; }
        public virtual DbSet<GoalCategory> GoalCategories { get; set; }
        public virtual DbSet<GoalCategoryTemp> GoalCategoryTemps { get; set; }
        public virtual DbSet<GoalPerson> GoalPeople { get; set; }
        public virtual DbSet<GoalPersonTemp> GoalPersonTemps { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<HistoryActionPlan> HistoryActionPlans { get; set; }
        public virtual DbSet<HistoryGetAllActionPlanView> HistoryGetAllActionPlanViews { get; set; }
        public virtual DbSet<HistoryGetAllFolderFile> HistoryGetAllFolderFiles { get; set; }
        public virtual DbSet<HistoryGetAllMarketsegmentView> HistoryGetAllMarketsegmentViews { get; set; }
        public virtual DbSet<HistoryGetAllSubmarketView> HistoryGetAllSubmarketViews { get; set; }
        public virtual DbSet<HistoryGetAllView> HistoryGetAllViews { get; set; }
        public virtual DbSet<ImageBrowser> ImageBrowsers { get; set; }
        public virtual DbSet<Independency> Independencies { get; set; }
        public virtual DbSet<IndependencyAccount> IndependencyAccounts { get; set; }
        public virtual DbSet<IndependencyRegion> IndependencyRegions { get; set; }
        public virtual DbSet<KpiActionFormatItem> KpiActionFormatItems { get; set; }
        public virtual DbSet<KpiActionFormatItemTemp> KpiActionFormatItemTemps { get; set; }
        public virtual DbSet<KpiActionIndex> KpiActionIndices { get; set; }
        public virtual DbSet<KpiActionIndexTemp> KpiActionIndexTemps { get; set; }
        public virtual DbSet<KpiActionMasterIndex> KpiActionMasterIndices { get; set; }
        public virtual DbSet<KpiActionMasterIndexTemp> KpiActionMasterIndexTemps { get; set; }
        public virtual DbSet<KpiActionMasterIndexTime> KpiActionMasterIndexTimes { get; set; }
        public virtual DbSet<KpiActionMasterIndexTimeTemp> KpiActionMasterIndexTimeTemps { get; set; }
        public virtual DbSet<KpiActionMasterTime> KpiActionMasterTimes { get; set; }
        public virtual DbSet<KpiActionMasterTimeTemp> KpiActionMasterTimeTemps { get; set; }
        public virtual DbSet<KpiActionMasterTopic> KpiActionMasterTopics { get; set; }
        public virtual DbSet<KpiActionMasterTopicTemp> KpiActionMasterTopicTemps { get; set; }
        public virtual DbSet<KpiFormat> KpiFormats { get; set; }
        public virtual DbSet<KpiFormatItem> KpiFormatItems { get; set; }
        public virtual DbSet<KpiFormatItemValue> KpiFormatItemValues { get; set; }
        public virtual DbSet<KpiFormatItemValueTemp> KpiFormatItemValueTemps { get; set; }
        public virtual DbSet<KpiFormatType> KpiFormatTypes { get; set; }
        public virtual DbSet<KpiGoalIndex> KpiGoalIndices { get; set; }
        public virtual DbSet<KpiGoalIndexLink> KpiGoalIndexLinks { get; set; }
        public virtual DbSet<KpiGoalIndexLinkTemp> KpiGoalIndexLinkTemps { get; set; }
        public virtual DbSet<KpiGoalIndexTemp> KpiGoalIndexTemps { get; set; }
        public virtual DbSet<KpiGoalIndexTime> KpiGoalIndexTimes { get; set; }
        public virtual DbSet<KpiGoalIndexTimeTemp> KpiGoalIndexTimeTemps { get; set; }
        public virtual DbSet<KpiGoalTime> KpiGoalTimes { get; set; }
        public virtual DbSet<KpiGoalTimeTemp> KpiGoalTimeTemps { get; set; }
        public virtual DbSet<KpiGoalTopic> KpiGoalTopics { get; set; }
        public virtual DbSet<KpiGoalTopicTemp> KpiGoalTopicTemps { get; set; }
        public virtual DbSet<KpiIndex> KpiIndices { get; set; }
        public virtual DbSet<KpiOutcomeIndexTime> KpiOutcomeIndexTimes { get; set; }
        public virtual DbSet<KpiOutcomeIndexTimeTemp> KpiOutcomeIndexTimeTemps { get; set; }
        public virtual DbSet<KpiOutcomeTime> KpiOutcomeTimes { get; set; }
        public virtual DbSet<KpiOutcomeTimeTemp> KpiOutcomeTimeTemps { get; set; }
        public virtual DbSet<KpiSettingIndex> KpiSettingIndices { get; set; }
        public virtual DbSet<KpiTopic> KpiTopics { get; set; }
        public virtual DbSet<KpiUnit> KpiUnits { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<Land> Lands { get; set; }
        public virtual DbSet<LandCostView> LandCostViews { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MTest> MTests { get; set; }
        public virtual DbSet<MainGoal> MainGoals { get; set; }
        public virtual DbSet<MainGoalFilter> MainGoalFilters { get; set; }
        public virtual DbSet<MainGoalTemp> MainGoalTemps { get; set; }
        public virtual DbSet<MaingoalReminderView> MaingoalReminderViews { get; set; }
        public virtual DbSet<MarketSegment> MarketSegments { get; set; }
        public virtual DbSet<MarketSegmentCostView> MarketSegmentCostViews { get; set; }
        public virtual DbSet<MarketSegmentRegion> MarketSegmentRegions { get; set; }
        public virtual DbSet<MarketsegmentTitle> MarketsegmentTitles { get; set; }
        public virtual DbSet<MasterBudget> MasterBudgets { get; set; }
        public virtual DbSet<Mtab> Mtabs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCompetition> ProductCompetitions { get; set; }
        public virtual DbSet<ProductCompetitionTemp> ProductCompetitionTemps { get; set; }
        public virtual DbSet<ProductEvaluation> ProductEvaluations { get; set; }
        public virtual DbSet<ProductEvaluationTemp> ProductEvaluationTemps { get; set; }
        public virtual DbSet<ProductFinance> ProductFinances { get; set; }
        public virtual DbSet<ProductFinanceTemp> ProductFinanceTemps { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductPosition> ProductPositions { get; set; }
        public virtual DbSet<ProductPositionChart> ProductPositionCharts { get; set; }
        public virtual DbSet<ProductPositionChartTemp> ProductPositionChartTemps { get; set; }
        public virtual DbSet<ProductPositionTemp> ProductPositionTemps { get; set; }
        public virtual DbSet<ProductSe> ProductSes { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectGroup> ProjectGroups { get; set; }
        public virtual DbSet<ProjectLanguage> ProjectLanguages { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RegionCostView> RegionCostViews { get; set; }
        public virtual DbSet<RegionEvaluation> RegionEvaluations { get; set; }
        public virtual DbSet<RegionTitle> RegionTitles { get; set; }
        public virtual DbSet<ReportActionGetCategoryView> ReportActionGetCategoryViews { get; set; }
        public virtual DbSet<ReportGoalGetCategoryView> ReportGoalGetCategoryViews { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleRight> RoleRights { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StatusProtocol> StatusProtocols { get; set; }
        public virtual DbSet<StatusProtocolGetByGoal> StatusProtocolGetByGoals { get; set; }
        public virtual DbSet<StatusProtocolTemp> StatusProtocolTemps { get; set; }
        public virtual DbSet<StatusProtocolViewByAction> StatusProtocolViewByActions { get; set; }
        public virtual DbSet<Strategy> Strategies { get; set; }
        public virtual DbSet<SubClient> SubClients { get; set; }
        public virtual DbSet<SubMarket> SubMarkets { get; set; }
        public virtual DbSet<SubMarketLabel> SubMarketLabels { get; set; }
        public virtual DbSet<SubMarketProduct> SubMarketProducts { get; set; }
        public virtual DbSet<SubMarketProductAccount> SubMarketProductAccounts { get; set; }
        public virtual DbSet<SubMarketProductAccountTemp> SubMarketProductAccountTemps { get; set; }
        public virtual DbSet<SubMarketProductTemp> SubMarketProductTemps { get; set; }
        public virtual DbSet<SubMarketSe> SubMarketSes { get; set; }
        public virtual DbSet<SubProduct> SubProducts { get; set; }
        public virtual DbSet<SubSwotanalyse> SubSwotanalyses { get; set; }
        public virtual DbSet<SubSwotanalyseTemp> SubSwotanalyseTemps { get; set; }
        public virtual DbSet<SubmarketCountEval> SubmarketCountEvals { get; set; }
        public virtual DbSet<SubmarketProductCountEval> SubmarketProductCountEvals { get; set; }
        public virtual DbSet<SwotTemplate> SwotTemplates { get; set; }
        public virtual DbSet<SwotTemplateAccount> SwotTemplateAccounts { get; set; }
        public virtual DbSet<Swotanalyse> Swotanalyses { get; set; }
        public virtual DbSet<SwotanalyseTemp> SwotanalyseTemps { get; set; }
        public virtual DbSet<TargetGroup> TargetGroups { get; set; }
        public virtual DbSet<TargetGroupTemp> TargetGroupTemps { get; set; }
        public virtual DbSet<TempFragenset> TempFragensets { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TodoAccount> TodoAccounts { get; set; }
        public virtual DbSet<TodoAccountTemp> TodoAccountTemps { get; set; }
        public virtual DbSet<VideoLink> VideoLinks { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=STRATSIGNER170424;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.ActiveInviteValue).HasMaxLength(100);

                entity.Property(e => e.ActiveValue)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Firm).HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.LastLoginedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Theme).HasMaxLength(50);

                entity.Property(e => e.TmpEmail).HasMaxLength(75);
            });

            modelBuilder.Entity<AccountCrmRole>(entity =>
            {
                entity.ToTable("AccountCrmRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccountLastAction>(entity =>
            {
                entity.ToTable("AccountLastAction");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AccountRole>(entity =>
            {
                entity.ToTable("AccountRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_AccountRole_Account");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountRole_Role");
            });

            modelBuilder.Entity<Models.Action>(entity =>
            {
                entity.ToTable("Action");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasComment("Id in Categories table");

                entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.ExpectedCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FibuSupplier).HasMaxLength(200);

                entity.Property(e => e.Finish).HasComment("Du kien ko dung ");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(130);

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.GoalId)
                    .HasConstraintName("FK_Action_MainGoal");
            });

            modelBuilder.Entity<ActionCategory>(entity =>
            {
                entity.ToTable("ActionCategory");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Category, 2 Field");
            });

            modelBuilder.Entity<ActionCategoryTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionCategoryTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ActionCost>(entity =>
            {
                entity.ToTable("ActionCost");

                entity.Property(e => e.Id).HasComment("Id in Categories table");

                entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FibuSupplier).HasMaxLength(200);

                entity.Property(e => e.IsConnectionUp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionCostTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionCostTemp");

                entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FibuSupplier).HasMaxLength(200);

                entity.Property(e => e.Id).HasComment("Id in Categories table");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionCustomView>(entity =>
            {
                entity.ToTable("ActionCustomView");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionCustomViewCategory>(entity =>
            {
                entity.ToTable("ActionCustomViewCategory");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActionDate");

                entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.ExpectedCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FibuSupplier).HasMaxLength(200);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(130);

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionFibu>(entity =>
            {
                entity.ToTable("ActionFibu");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FibuDate).HasColumnType("datetime");

                entity.Property(e => e.FibuPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionFibuTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionFibuTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FibuDate).HasColumnType("datetime");

                entity.Property(e => e.FibuPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionFormat>(entity =>
            {
                entity.ToTable("ActionFormat");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionFormatTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionFormatTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPerson>(entity =>
            {
                entity.ToTable("ActionPerson");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Normal Person, 2: Involved Person");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ActionPeople)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPerson_Account");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionPeople)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_ActionPerson_Action");
            });

            modelBuilder.Entity<ActionPersonTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionPersonTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TypeId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Normal Person, 2: Involved Person");
            });

            modelBuilder.Entity<ActionPlanColumn>(entity =>
            {
                entity.ToTable("ActionPlanColumn");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasComment("1 Journey group,2  Journey,3 Sub-journey");

                entity.Property(e => e.Mcount).HasColumnName("MCount");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ActionPlanColumnTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionPlanColumnTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasComment("1 Journey group,2  Journey,3 Sub-journey");

                entity.Property(e => e.Mcount).HasColumnName("MCount");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ActionPlanConnection>(entity =>
            {
                entity.ToTable("ActionPlanConnection");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1: Action-Submarket, 2: Action-Product, 3: Goal-Submarket, 4: Goal-Product");
            });

            modelBuilder.Entity<ActionPlanCustomerJourney>(entity =>
            {
                entity.ToTable("ActionPlanCustomerJourney");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GoalActionTypeId).HasComment("1 Maingoal, 2 SubGoal, 3 Action");

                entity.Property(e => e.TypeId).HasComment("1 Journey group,2  Journey,3 Sub-journey");
            });

            modelBuilder.Entity<ActionPlanCustomerJourneyTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionPlanCustomerJourneyTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPlanExpand>(entity =>
            {
                entity.ToTable("ActionPlanExpand");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPlanLink>(entity =>
            {
                entity.ToTable("ActionPlanLink");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GoalActionTypeId).HasComment("1: MainGoal, 2: SubGoal, 3: Action");

                entity.Property(e => e.LinkTypeId).HasComment("1: MainGoal, 2: SubGoal, 3: Action");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPlanRegion>(entity =>
            {
                entity.ToTable("ActionPlanRegion");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GoalActionTypeId).HasComment("1: maingoal, 2: subgoal, 3: action");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPlanRegionTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionPlanRegionTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPlanReminder>(entity =>
            {
                entity.ToTable("ActionPlanReminder");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentLang)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReminderTime).HasColumnType("time(0)");

                entity.Property(e => e.TypeId).HasComment("1 GoalId,2 ActionCost,3 Activity, 4, 5 ActionTodo");
            });

            modelBuilder.Entity<ActionPlanSubClient>(entity =>
            {
                entity.ToTable("ActionPlanSubClient");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GoalActionTypeId).HasComment("1 Maingoal, 2 SubGoal, 3 Action");

                entity.Property(e => e.TypeId).HasComment("1 Marketsegment, 2 Submarket, 3 SubClient, 4 Activity");
            });

            modelBuilder.Entity<ActionPlanSubClientTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionPlanSubClientTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionPlanSubProduct>(entity =>
            {
                entity.ToTable("ActionPlanSubProduct");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GoalActionTypeId).HasComment("1 Maingoal, 2 SubGoal, 3 Action");

                entity.Property(e => e.TypeId).HasComment("1 ProductGroup, 2 Product, 3 SubProduct");
            });

            modelBuilder.Entity<ActionPlanSubProductTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionPlanSubProductTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionReminderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActionReminderView");
            });

            modelBuilder.Entity<ActionTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionTemp");

                entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.ExpectedCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FibuSupplier).HasMaxLength(200);

                entity.Property(e => e.Mcolor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MColor");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(130);

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionTitleLang>(entity =>
            {
                entity.ToTable("ActionTitleLang");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TitleName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.TypeId).HasComment("1 Main Goal, 2 Sub Goal, 3 Action");
            });

            modelBuilder.Entity<ActionTodo>(entity =>
            {
                entity.ToTable("ActionTodo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionTodoDepartment>(entity =>
            {
                entity.ToTable("ActionTodoDepartment");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionTodoDiscussion>(entity =>
            {
                entity.ToTable("ActionTodoDiscussion");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Discussion).IsRequired();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Account, 2: Todo Account");
            });

            modelBuilder.Entity<ActionTodoNotify>(entity =>
            {
                entity.ToTable("ActionTodoNotify");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionTodoDiscussionId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Account, 2: Todo Account");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionTodoPerson>(entity =>
            {
                entity.ToTable("ActionTodoPerson");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Account, 2: Todo Account");
            });

            modelBuilder.Entity<ActionTodoPersonTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionTodoPersonTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Account, 2: Todo Account");
            });

            modelBuilder.Entity<ActionTodoTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionTodoTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionUpStreamConnection>(entity =>
            {
                entity.ToTable("ActionUpStreamConnection");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionUpStreamConnections)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionUpStreamConnection_Action1");
            });

            modelBuilder.Entity<ApDemand>(entity =>
            {
                entity.ToTable("ApDemand");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriteriaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DemandText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExpectationText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApDemandChart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApDemandChart");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApDemandChartEvaluation>(entity =>
            {
                entity.ToTable("ApDemandChartEvaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApDemandChartEvaluationTemp>(entity =>
            {
                entity.ToTable("ApDemandChartEvaluationTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApDemandChartTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApDemandChartTemp");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApDemandTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApDemandTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DemandText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExpectationText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsExpectation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApEvaluation>(entity =>
            {
                entity.ToTable("ApEvaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Evaluation).HasComment("1: New, 2 Old");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("1: Goal, 2: Action");
            });

            modelBuilder.Entity<ApEvaluationTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApEvaluationTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Evaluation).HasComment("1: New, 2 Old");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApSubSwotanalyse>(entity =>
            {
                entity.ToTable("ApSubSwotanalyse");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApSubSwotanalyseTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApSubSwotanalyseTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApSwotanalyse>(entity =>
            {
                entity.ToTable("ApSwotanalyse");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApSwotanalyseTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApSwotanalyseTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApTargetGroup>(entity =>
            {
                entity.ToTable("ApTargetGroup");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApTargetGroupTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApTargetGroupTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AssignSetting>(entity =>
            {
                entity.ToTable("AssignSetting");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasComment("SubmarketSe Id");

                entity.Property(e => e.ObjectId).HasComment("Submarket, SubClient Id");

                entity.Property(e => e.TypeId).HasComment("1 Product group, 2 Product, 3 SubProduct, 4 Submarket, 5 Subclient");
            });

            modelBuilder.Entity<AttachFile>(entity =>
            {
                entity.ToTable("AttachFile");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BoardColumn>(entity =>
            {
                entity.ToTable("BoardColumn");

                entity.Property(e => e.Id).HasComment("Id in Categories table");

                entity.Property(e => e.ColorId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDesc)
                    .HasColumnName("IsDESC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSyncOrder).HasComment("Đánh dấu data order của column đã được đồng bộ lại chưa, nếu chưa thì sẽ có lệnh truyện id và index cua column để update lại index cho các phần tử trong column");

                entity.Property(e => e.IsXy).HasColumnName("IsXY");

                entity.Property(e => e.Mcount).HasColumnName("MCount");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SortTypeId).HasComment("IsDueDate: 1, Kpi: 2, Evaluation : 3");

                entity.HasOne(d => d.BoardLine)
                    .WithMany(p => p.BoardColumns)
                    .HasForeignKey(d => d.BoardLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardColumn_BoardLine");
            });

            modelBuilder.Entity<BoardColumnActionPlan>(entity =>
            {
                entity.ToTable("BoardColumnActionPlan");

                entity.Property(e => e.BoardColumnId).HasComment("1: Action-Submarket, 2: Action-Product, 3: Goal-Submarket, 4: Goal-Product");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 MainGoal, 2 SubGoal, 3 Action");
            });

            modelBuilder.Entity<BoardExpand>(entity =>
            {
                entity.ToTable("BoardExpand");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BoardFilter>(entity =>
            {
                entity.ToTable("BoardFilter");

                entity.Property(e => e.ActionPlanTypeId).HasComment("1 MainGoal, 2 Sub Goal, 3 Action");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Filter, 2 Subordinate");

                entity.HasOne(d => d.BoardLine)
                    .WithMany(p => p.BoardFilters)
                    .HasForeignKey(d => d.BoardLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardFilter_BoardLine");
            });

            modelBuilder.Entity<BoardFilterSubordinate>(entity =>
            {
                entity.ToTable("BoardFilterSubordinate");

                entity.Property(e => e.BoardColumnId).HasComment("1 MainGoal, 2 SubGoal, 3 Action");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");
            });

            modelBuilder.Entity<BoardLine>(entity =>
            {
                entity.ToTable("BoardLine");

                entity.Property(e => e.Id).HasComment("Id in Categories table");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TypeId).HasComment("1 Gantt, 2 Column");

                entity.HasOne(d => d.BoardName)
                    .WithMany(p => p.BoardLines)
                    .HasForeignKey(d => d.BoardNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardLine_BoardName");
            });

            modelBuilder.Entity<BoardLineExpand>(entity =>
            {
                entity.ToTable("BoardLineExpand");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BoardName>(entity =>
            {
                entity.ToTable("BoardName");

                entity.Property(e => e.Id).HasComment("Id in Categories table");

                entity.Property(e => e.ColorId).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<BoardNamePerson>(entity =>
            {
                entity.ToTable("BoardNamePerson");

                entity.Property(e => e.Id).HasComment("");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Person, 2 Department");

                entity.HasOne(d => d.BoardName)
                    .WithMany(p => p.BoardNamePeople)
                    .HasForeignKey(d => d.BoardNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardNamePerson_BoardName");
            });

            modelBuilder.Entity<CategoriesLanguage>(entity =>
            {
                entity.ToTable("CategoriesLanguage");

                entity.Property(e => e.ClientKeyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LangId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ParentType).HasComment("1.Market, 2 Org, 3 Peron, 4, Activies");

                entity.Property(e => e.Type).HasComment("1: Category Goal; 2: Category Action; 3: Goal Evaluation; 4: Curency; 5: Strategy; 6: Instrument,7 Area, 8 ActionStatus,9 categoryPlanning, 10 categoryAdvertisingMaterials, 11 categoryAdvertiser, 12 ProjectLanguage, 13 categoryFibu, 14 Supplier,15 Subjet\\Thema");
            });

            modelBuilder.Entity<CodeLastAction>(entity =>
            {
                entity.ToTable("CodeLastAction");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("Configuration");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CrmAccountSmtp>(entity =>
            {
                entity.ToTable("CrmAccountSmtp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Port).HasMaxLength(20);

                entity.Property(e => e.Smtpserver)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SMTPServer");

                entity.Property(e => e.Ssl).HasColumnName("SSL");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CrmActivity>(entity =>
            {
                entity.ToTable("CrmActivity");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.IsWebForm)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 = green");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmActivities)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_CrmActivity_Project");
            });

            modelBuilder.Entity<CrmActivityAccountView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityAccountView");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<CrmActivityCategory>(entity =>
            {
                entity.ToTable("CrmActivityCategory");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmActivityCategoryViewForFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityCategoryViewForFilter");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmActivityPerson>(entity =>
            {
                entity.ToTable("CrmActivityPerson");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsRead)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Normal, 1 Unread, 2 Read");

                entity.HasOne(d => d.CrmActivity)
                    .WithMany(p => p.CrmActivityPeople)
                    .HasForeignKey(d => d.CrmActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmActivityPerson_CrmActivity");
            });

            modelBuilder.Entity<CrmActivityPersonNameOneOrgTopView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityPersonNameOneOrgTopView");
            });

            modelBuilder.Entity<CrmActivityPersonNameView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityPersonNameView");

                entity.Property(e => e.DearPersonName).HasMaxLength(100);
            });

            modelBuilder.Entity<CrmActivityPersonViewForFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityPersonViewForFilter");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<CrmActivityRelationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityRelationView");

                entity.Property(e => e.ActivityName).HasMaxLength(100);

                entity.Property(e => e.CatActivityName).HasMaxLength(200);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmActivityRelationship>(entity =>
            {
                entity.ToTable("CrmActivityRelationship");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Activity-Person, 2 Activity - Organisation");

                entity.HasOne(d => d.CrmActivity)
                    .WithMany(p => p.CrmActivityRelationships)
                    .HasForeignKey(d => d.CrmActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmActivityRelationship_CrmActivity");
            });

            modelBuilder.Entity<CrmActivityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityView");

                entity.Property(e => e.CatName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PiorityName).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmActivityViewActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmActivityView_Activity");

                entity.Property(e => e.CatName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PiorityName).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmAddress>(entity =>
            {
                entity.ToTable("CrmAddress");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasComment("CrmOrganisationId, CrmPersonId");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Nr).HasMaxLength(250);

                entity.Property(e => e.Ort).HasMaxLength(250);

                entity.Property(e => e.Plz).HasMaxLength(250);

                entity.Property(e => e.Street).HasMaxLength(250);

                entity.Property(e => e.TypeId).HasComment("2 Organisation, 3 Person");
            });

            modelBuilder.Entity<CrmAddressView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmAddressView");

                entity.Property(e => e.CatAddressName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmLandName).HasMaxLength(200);

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.Nr).HasMaxLength(250);

                entity.Property(e => e.Ort).HasMaxLength(250);

                entity.Property(e => e.Plz).HasMaxLength(250);

                entity.Property(e => e.Street).HasMaxLength(250);
            });

            modelBuilder.Entity<CrmAnswer>(entity =>
            {
                entity.ToTable("CrmAnswer");

                entity.Property(e => e.Article).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LinkQuestionId).HasComment("-1 hide all, 0 none next question, n nex question");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Nr).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CrmQuestion)
                    .WithMany(p => p.CrmAnswers)
                    .HasForeignKey(d => d.CrmQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmAnswer_CrmQuestion");
            });

            modelBuilder.Entity<CrmAnswerOption>(entity =>
            {
                entity.HasKey(e => e.CrmAnswerId)
                    .HasName("PK_CrmAnswerOption_1");

                entity.ToTable("CrmAnswerOption");

                entity.Property(e => e.CrmAnswerId).ValueGeneratedNever();

                entity.Property(e => e.GreaterThan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LessThan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.CrmAnswer)
                    .WithOne(p => p.CrmAnswerOption)
                    .HasForeignKey<CrmAnswerOption>(d => d.CrmAnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmAnswerOption_CrmAnswer");
            });

            modelBuilder.Entity<CrmAnswerPerson>(entity =>
            {
                entity.ToTable("CrmAnswerPerson");

                entity.Property(e => e.Article).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmActivityId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Nr).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusId).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<CrmCategoriesExtension>(entity =>
            {
                entity.ToTable("CrmCategoriesExtension");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasComment("Voi CheckStatus 1 là check, 0 la khong check");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsAutoSend).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsManualSend)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 khong check, 1 check manual, 2 auto");

                entity.Property(e => e.IsUserSoftware).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Qday)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QDay");

                entity.Property(e => e.Qtime).HasColumnName("QTime");

                entity.Property(e => e.TypeId).HasComment("1 Crowd, 2 Word Template, 3 Check Status");
            });

            modelBuilder.Entity<CrmCategoriesTest>(entity =>
            {
                entity.ToTable("CrmCategoriesTest");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CrmCategory>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ParentType).HasComment("1.Market, 2 Org, 3 Peron, 4, Activies");

                entity.Property(e => e.Type).HasComment("1: Category Goal; 2: Category Action; 3: Goal Evaluation; 4: Curency; 5: Strategy; 6: Instrument,7 Area, 8 ActionStatus,9 categoryPlanning, 10 categoryAdvertisingMaterials, 11 categoryAdvertiser, 12 ProjectLanguage, 13 categoryFibu, 14 Supplier");
            });

            modelBuilder.Entity<CrmCrowdProject>(entity =>
            {
                entity.ToTable("CrmCrowdProject");

                entity.Property(e => e.CampaignTime).HasColumnType("time(0)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentLang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('de')");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsOrderLabel)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Logo).HasMaxLength(500);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.QuestionTitle).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.HasOne(d => d.CrmCrowdProjectGroup)
                    .WithMany(p => p.CrmCrowdProjects)
                    .HasForeignKey(d => d.CrmCrowdProjectGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmCrowdProject_CrmCrowdProjectGroup");
            });

            modelBuilder.Entity<CrmCrowdProjectCc>(entity =>
            {
                entity.ToTable("CrmCrowdProjectCC");

                entity.Property(e => e.AccountTypeId).HasComment("1 Account, 2 CRM Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 CC, 2 BCC");
            });

            modelBuilder.Entity<CrmCrowdProjectGroup>(entity =>
            {
                entity.ToTable("CrmCrowdProjectGroup");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmCrowdProjectGroups)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmCrowdProjectGroup_Project");
            });

            modelBuilder.Entity<CrmCrowdProjectMonitor>(entity =>
            {
                entity.ToTable("CrmCrowdProjectMonitor");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmCrowdProjectPerson>(entity =>
            {
                entity.ToTable("CrmCrowdProjectPerson");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmActivityId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstTimeLoginDate).HasColumnType("datetime");

                entity.Property(e => e.IsAccess).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<CrmFilter>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsNavigation).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShare).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mcolor)
                    .HasMaxLength(50)
                    .HasColumnName("MColor");

                entity.Property(e => e.Mcount).HasColumnName("MCount");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("2 org, 3 person, 4 activity");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CrmFilters)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmFilters_Account");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmFilters)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_CrmFilters_Project");
            });

            modelBuilder.Entity<CrmFiltersCrowd>(entity =>
            {
                entity.ToTable("CrmFiltersCrowd");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrowdProjectId).HasComment("1 Standard, 2 Customer");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CrmFiltersCrowds)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmFiltersCrowd_Account");

                entity.HasOne(d => d.CrowdProject)
                    .WithMany(p => p.CrmFiltersCrowds)
                    .HasForeignKey(d => d.CrowdProjectId)
                    .HasConstraintName("FK_CrmFiltersCrowd_CrmCrowdProject");
            });

            modelBuilder.Entity<CrmFragenset>(entity =>
            {
                entity.ToTable("CrmFragenset");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CrmFragensetGroup)
                    .WithMany(p => p.CrmFragensets)
                    .HasForeignKey(d => d.CrmFragensetGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmFragenset_CrmFragensetGroup");
            });

            modelBuilder.Entity<CrmFragensetGroup>(entity =>
            {
                entity.ToTable("CrmFragensetGroup");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmFragensetGroups)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmFragensetGroup_Project");
            });

            modelBuilder.Entity<CrmGroupQuestionReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmGroupQuestionReportView");
            });

            modelBuilder.Entity<CrmImportTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrmImportTemp");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.NameOrganisation).HasMaxLength(100);

                entity.Property(e => e.Ort).HasMaxLength(250);

                entity.Property(e => e.Plz).HasMaxLength(250);

                entity.Property(e => e.Street).HasMaxLength(250);
            });

            modelBuilder.Entity<CrmInformation>(entity =>
            {
                entity.ToTable("CrmInformation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasComment("CrmOrganisationId, CrmPersonId");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("2 Organisation, 3 Person");
            });

            modelBuilder.Entity<CrmInformationFilterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmInformationFilterView");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CrmInformationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmInformationView");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CrmLanFilter>(entity =>
            {
                entity.ToTable("CrmLanFilter");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CrmLinkQuestion>(entity =>
            {
                entity.ToTable("CrmLinkQuestion");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.HasOne(d => d.CrmAnswer)
                    .WithMany(p => p.CrmLinkQuestions)
                    .HasForeignKey(d => d.CrmAnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmLinkQuestion_CrmAnswer");
            });

            modelBuilder.Entity<CrmOrganisation>(entity =>
            {
                entity.ToTable("CrmOrganisation");

                entity.Property(e => e.ApprovedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KundenNr).HasMaxLength(50);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmOrganisations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmOrganisation_Project");
            });

            modelBuilder.Entity<CrmOrganisationRelationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationRelationView");
            });

            modelBuilder.Entity<CrmOrganisationRelationship>(entity =>
            {
                entity.ToTable("CrmOrganisationRelationship");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmOrganisationResponsibility>(entity =>
            {
                entity.ToTable("CrmOrganisationResponsibility");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmOrganisationResponsibilityForFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationResponsibilityForFilter");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<CrmOrganisationResponsibilityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationResponsibilityView");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<CrmOrganisationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationView");

                entity.Property(e => e.BranchName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Employee).HasMaxLength(200);

                entity.Property(e => e.LegalForm).HasMaxLength(200);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Revenue).HasMaxLength(200);
            });

            modelBuilder.Entity<CrmOrganisationViewForFilterByActivityId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationViewForFilterByActivityId");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CrmOrganisationViewOrganisation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationView_Organisation");

                entity.Property(e => e.BranchName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmLandName).HasMaxLength(200);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Employee).HasMaxLength(200);

                entity.Property(e => e.KundenNr).HasMaxLength(50);

                entity.Property(e => e.LegalForm).HasMaxLength(200);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nr).HasMaxLength(250);

                entity.Property(e => e.Ort).HasMaxLength(250);

                entity.Property(e => e.Plz).HasMaxLength(250);

                entity.Property(e => e.Revenue).HasMaxLength(200);

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.Street).HasMaxLength(250);
            });

            modelBuilder.Entity<CrmOrganisationWithDueDateView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationWithDueDateView");

                entity.Property(e => e.DueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmOrganisationWithPersonView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmOrganisationWithPersonView");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CrmPerson>(entity =>
            {
                entity.ToTable("CrmPerson");

                entity.Property(e => e.ApprovedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Hidden Person");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmPeople)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmPerson_Project");
            });

            modelBuilder.Entity<CrmPersonHost>(entity =>
            {
                entity.ToTable("CrmPersonHost");

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmActivityId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EmuleId).HasMaxLength(100);

                entity.Property(e => e.HostName).HasMaxLength(300);

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.Land).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Protocol).HasMaxLength(100);

                entity.Property(e => e.Region).HasMaxLength(200);

                entity.Property(e => e.RemotePort).HasMaxLength(20);

                entity.Property(e => e.StatusId).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<CrmPersonPositionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonPositionView");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PositionName).HasMaxLength(200);
            });

            modelBuilder.Entity<CrmPersonRelationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonRelationView");
            });

            modelBuilder.Entity<CrmPersonRelationship>(entity =>
            {
                entity.ToTable("CrmPersonRelationship");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Person-Person, 2 Person - Organisation");

                entity.HasOne(d => d.CrmPerson)
                    .WithMany(p => p.CrmPersonRelationships)
                    .HasForeignKey(d => d.CrmPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmPersonRelationship_CrmPerson");
            });

            modelBuilder.Entity<CrmPersonReminder>(entity =>
            {
                entity.ToTable("CrmPersonReminder");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentLang)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReminderTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<CrmPersonResponsibility>(entity =>
            {
                entity.ToTable("CrmPersonResponsibility");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmPersonResponsibilityForFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonResponsibilityForFilter");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<CrmPersonResponsibilityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonResponsibilityView");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<CrmPersonView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonView");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(201);
            });

            modelBuilder.Entity<CrmPersonViewCrowd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonView_Crowd");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(201);
            });

            modelBuilder.Entity<CrmPersonViewForFilterByActivityId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonViewForFilterByActivityId");

                entity.Property(e => e.Name).HasMaxLength(201);
            });

            modelBuilder.Entity<CrmPersonViewOrganisation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonView_Organisation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PositionName).HasMaxLength(200);

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<CrmPersonWithDueDateView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPersonWithDueDateView");

                entity.Property(e => e.DueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmPosition>(entity =>
            {
                entity.ToTable("CrmPosition");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkingDate).HasColumnType("datetime");

                entity.HasOne(d => d.CrmOrganisation)
                    .WithMany(p => p.CrmPositions)
                    .HasForeignKey(d => d.CrmOrganisationId)
                    .HasConstraintName("FK_CrmPosition_CrmOrganisation");

                entity.HasOne(d => d.CrmPerson)
                    .WithMany(p => p.CrmPositions)
                    .HasForeignKey(d => d.CrmPersonId)
                    .HasConstraintName("FK_CrmPosition_CrmPerson");
            });

            modelBuilder.Entity<CrmPositionMaxMindexView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPositionMaxMIndexView");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CrmPositionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmPositionView");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CrmQuestion>(entity =>
            {
                entity.ToTable("CrmQuestion");

                entity.Property(e => e.Article).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Nr).HasMaxLength(100);

                entity.Property(e => e.Price).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasMaxLength(100);

                entity.Property(e => e.Symbol).HasMaxLength(10);

                entity.Property(e => e.TypeId).HasComment("rating = 1, simple choice = 2, simple drop = 3, multiple choice = 4, singleline = 7, multiline line=8 , image = 9,  Data = 10");

                entity.HasOne(d => d.CrmQuestionGroup)
                    .WithMany(p => p.CrmQuestions)
                    .HasForeignKey(d => d.CrmQuestionGroupId)
                    .HasConstraintName("FK_CrmQuestion_CrmQuestionGroup");
            });

            modelBuilder.Entity<CrmQuestionAnswerScaleGroupQuestionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmQuestionAnswerScaleGroupQuestionView");
            });

            modelBuilder.Entity<CrmQuestionAnswerScaleThemaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmQuestionAnswerScaleThemaView");
            });

            modelBuilder.Entity<CrmQuestionCountView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmQuestionCountView");
            });

            modelBuilder.Entity<CrmQuestionGroup>(entity =>
            {
                entity.ToTable("CrmQuestionGroup");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CrmThema)
                    .WithMany(p => p.CrmQuestionGroups)
                    .HasForeignKey(d => d.CrmThemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmQuestionGroup_CrmThema");
            });

            modelBuilder.Entity<CrmQuestionPerson>(entity =>
            {
                entity.ToTable("CrmQuestionPerson");

                entity.Property(e => e.CrmActivityId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.StatusId).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.CrmQuestion)
                    .WithMany(p => p.CrmQuestionPeople)
                    .HasForeignKey(d => d.CrmQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmQuestionPerson_CrmQuestion");
            });

            modelBuilder.Entity<CrmQuestionPersonCountView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmQuestionPersonCountView");
            });

            modelBuilder.Entity<CrmSourcingEmailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmSourcingEmailView");
            });

            modelBuilder.Entity<CrmStatusProtocol>(entity =>
            {
                entity.ToTable("CrmStatusProtocol");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsCheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOpenQuestion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSend).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUpdateWord).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasComment("Join voi bang Categories thong qua CateId");

                entity.HasOne(d => d.CrmActivity)
                    .WithMany(p => p.CrmStatusProtocols)
                    .HasForeignKey(d => d.CrmActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmStatusProtocol_CrmActivity");
            });

            modelBuilder.Entity<CrmStatusProtocolQuestionnaire>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmStatusProtocolQuestionnaire");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Qday)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QDay");

                entity.Property(e => e.Qtime).HasColumnName("QTime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmStatusProtocolView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmStatusProtocolView");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CrmStatusProtocolViewForFilterByActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmStatusProtocolViewForFilterByActivity");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.StatusName).HasMaxLength(200);
            });

            modelBuilder.Entity<CrmStatusProtocolViewLastStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmStatusProtocolViewLastStatus");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.StatusName).HasMaxLength(200);
            });

            modelBuilder.Entity<CrmTag>(entity =>
            {
                entity.ToTable("CrmTag");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("2 Organisation, 3 Person, ");
            });

            modelBuilder.Entity<CrmTagCrowd>(entity =>
            {
                entity.ToTable("CrmTagCrowd");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("2 Answer Organisation Tag, 3 Answer Person Tag, 4 Crowd");
            });

            modelBuilder.Entity<CrmTagMapping>(entity =>
            {
                entity.ToTable("CrmTagMapping");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmActivityId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.CrmCrowdProject)
                    .WithMany(p => p.CrmTagMappings)
                    .HasForeignKey(d => d.CrmCrowdProjectId)
                    .HasConstraintName("FK_CrmTagMapping_CrmCrowdProject");

                entity.HasOne(d => d.CrmTag)
                    .WithMany(p => p.CrmTagMappings)
                    .HasForeignKey(d => d.CrmTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmTagMapping_CrmTag");
            });

            modelBuilder.Entity<CrmTagView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CrmTagView");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.TagName).HasMaxLength(200);
            });

            modelBuilder.Entity<CrmThema>(entity =>
            {
                entity.ToTable("CrmThema");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CrmFragenset)
                    .WithMany(p => p.CrmThemas)
                    .HasForeignKey(d => d.CrmFragensetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmThema_CrmFragenset");
            });

            modelBuilder.Entity<CrmToken>(entity =>
            {
                entity.ToTable("CrmToken");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeletedBy)
                    .HasColumnName("deleted_by")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(128)
                    .HasColumnName("device_id");

                entity.Property(e => e.LoginToken)
                    .HasMaxLength(200)
                    .HasColumnName("login_token");

                entity.Property(e => e.Platform)
                    .HasMaxLength(128)
                    .HasColumnName("platform");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerJourney>(entity =>
            {
                entity.ToTable("CustomerJourney");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("1: ProductGroup, 2: Product, 3: SubProduct");
            });

            modelBuilder.Entity<DashboardAccount>(entity =>
            {
                entity.ToTable("DashboardAccount");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Type).HasComment("1 MainGoal, 2 Sub Goal, 3 Action, 4 Trends");
            });

            modelBuilder.Entity<DashboardConfig>(entity =>
            {
                entity.ToTable("DashboardConfig");

                entity.Property(e => e.Mkey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MKey")
                    .HasComment("");

                entity.Property(e => e.Type).HasComment("1 Critical Path, 2 Slider Trend, 3 Trend Table, 4 Marketsegment, 5 Submarket, 6 Action plan");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DashboardPositionAccount>(entity =>
            {
                entity.ToTable("DashboardPositionAccount");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Dash Board, 2: Marketing Mix");
            });

            modelBuilder.Entity<Demand>(entity =>
            {
                entity.ToTable("Demand");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DemandText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExpectationText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.TargetGroup)
                    .WithMany(p => p.Demands)
                    .HasForeignKey(d => d.TargetGroupId)
                    .HasConstraintName("FK_Demand_TargetGroup");
            });

            modelBuilder.Entity<DemandChart>(entity =>
            {
                entity.ToTable("DemandChart");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.DemandCharts)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_DemandChart_SubMarketProduct");
            });

            modelBuilder.Entity<DemandChartEvaluation>(entity =>
            {
                entity.ToTable("DemandChartEvaluation");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DemandChart)
                    .WithMany(p => p.DemandChartEvaluations)
                    .HasForeignKey(d => d.DemandChartId)
                    .HasConstraintName("FK_DemandChartEvaluation_DemandChart");

                entity.HasOne(d => d.Demand)
                    .WithMany(p => p.DemandChartEvaluations)
                    .HasForeignKey(d => d.DemandId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DemandChartEvaluation_Demand");
            });

            modelBuilder.Entity<DemandChartEvaluationTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemandChartEvaluationTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DemandChartTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemandChartTemp");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Template)
                    .WithMany()
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_DemandChartTemp_Template");
            });

            modelBuilder.Entity<DemandTemp>(entity =>
            {
                entity.ToTable("DemandTemp");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DemandText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExpectationText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsExpectation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DepartmentAccount>(entity =>
            {
                entity.ToTable("DepartmentAccount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DepartmentRole>(entity =>
            {
                entity.ToTable("DepartmentRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TabId).HasComment("Page");
            });

            modelBuilder.Entity<DocumentSe>(entity =>
            {
                entity.ToTable("DocumentSe");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasComment("Id of SubMarket or Product structure.");

                entity.Property(e => e.LinkType).HasComment("1: MarketSegment\\ProductGroup, 2: StackHolder\\Product, 3: SubClient\\SubProduct");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Product, 2 Submarket");
            });

            modelBuilder.Entity<FibuKonten>(entity =>
            {
                entity.ToTable("FibuKonten");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Nr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FibuLandRegion>(entity =>
            {
                entity.ToTable("FibuLandRegion");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mtype).HasColumnName("MType");

                entity.Property(e => e.Nr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Type).HasComment("1: Submarket, 2: ActionPlan, 3: MaketingMix, 4:PortiloAnalyse, 5:Dashboard; 7:MarketSegment; 8:Budget; 9:AdvertisingMaterial; 10:MasterGoal; 11:Campaign; 12:ProductAndStakeHolderGroup; 13:TeamBoard");
            });

            modelBuilder.Entity<FolderFieldAssign>(entity =>
            {
                entity.ToTable("FolderFieldAssign");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssignIdU).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FromAssigned).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<FolderFieldAssignTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FolderFieldAssignTemp");

                entity.Property(e => e.AssignIdU).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FromAssigned).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<FolderFile>(entity =>
            {
                entity.ToTable("FolderFile");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Type).HasComment("0 is Folder, >0 is File");
            });

            modelBuilder.Entity<FolderFileAssignReport>(entity =>
            {
                entity.ToTable("FolderFileAssignReport");

                entity.Property(e => e.CrmActivityId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.StatusId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TypeId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1. Auto PDF, 2 User Software");

                entity.HasOne(d => d.FolderFileAssign)
                    .WithMany(p => p.FolderFileAssignReports)
                    .HasForeignKey(d => d.FolderFileAssignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FolderFileAssignReport_FolderFieldAssign");
            });

            modelBuilder.Entity<FolderFileView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FolderFileView");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpath)
                    .IsUnicode(false)
                    .HasColumnName("MPath");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<GetActualCostByMainGoalIdView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetActualCostByMainGoalIdView");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetActualCostByMainGoalIdViewForCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetActualCostByMainGoalIdViewForCalendar");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetActualCostBySubGoalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetActualCostBySubGoalView");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetActualCostBySubGoalViewForCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetActualCostBySubGoalViewForCalendar");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetAllGoalActionDashboardView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetAllGoalActionDashboardView");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<GetAvgSubmarket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_Avg_Submarket");
            });

            modelBuilder.Entity<GetExpectedCostByMainGoalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetExpectedCostByMainGoalView");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetExpectedCostByMainGoalViewForCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetExpectedCostByMainGoalViewForCalendar");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetExpectedCostBySubGoalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetExpectedCostBySubGoalView");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetExpectedCostBySubGoalViewForCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetExpectedCostBySubGoalViewForCalendar");

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<GetMarketSegmentRegionCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_MarketSegmentRegion_Cost");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GetProductFinanceCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_ProductFinance_Cost");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GetRegionCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_Region_Currency");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<GetSubMarketProductCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_SubMarketProduct_Cost");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GoalCategory>(entity =>
            {
                entity.ToTable("GoalCategory");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Category, 2 Field");
            });

            modelBuilder.Entity<GoalCategoryTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GoalCategoryTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<GoalPerson>(entity =>
            {
                entity.ToTable("GoalPerson");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.GoalPeople)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_GoalPerson_Account");

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.GoalPeople)
                    .HasForeignKey(d => d.GoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GoalPerson_MainGoal");
            });

            modelBuilder.Entity<GoalPersonTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GoalPersonTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryActionPlan>(entity =>
            {
                entity.ToTable("HistoryActionPlan");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryGetAllActionPlanView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("History_GetAllActionPlanView");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpath)
                    .HasMaxLength(1736)
                    .HasColumnName("MPath");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryGetAllFolderFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("History_GetAllFolderFile");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpath)
                    .IsUnicode(false)
                    .HasColumnName("MPath");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryGetAllMarketsegmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("History_GetAllMarketsegmentView");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpath).HasColumnName("MPath");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryGetAllSubmarketView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("History_GetAllSubmarketView");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpath)
                    .IsRequired()
                    .HasMaxLength(605)
                    .HasColumnName("MPath");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryGetAllView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("History_GetAllView");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpath).HasColumnName("MPath");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<ImageBrowser>(entity =>
            {
                entity.ToTable("ImageBrowser");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Independency>(entity =>
            {
                entity.ToTable("Independency");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.SelectAllRegion).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Independencies)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Independency_Project");
            });

            modelBuilder.Entity<IndependencyAccount>(entity =>
            {
                entity.ToTable("IndependencyAccount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndependencyRegion>(entity =>
            {
                entity.ToTable("IndependencyRegion");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Independency)
                    .WithMany(p => p.IndependencyRegions)
                    .HasForeignKey(d => d.IndependencyId)
                    .HasConstraintName("FK_IndependencyRegion_Independency");
            });

            modelBuilder.Entity<KpiActionFormatItem>(entity =>
            {
                entity.ToTable("KpiActionFormatItem");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mvalue).HasColumnName("MValue");
            });

            modelBuilder.Entity<KpiActionFormatItemTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiActionFormatItemTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mvalue).HasColumnName("MValue");
            });

            modelBuilder.Entity<KpiActionIndex>(entity =>
            {
                entity.ToTable("KpiActionIndex");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsCalculate).HasDefaultValueSql("((1))");

                entity.Property(e => e.KpiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LstValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiActionIndexTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiActionIndexTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsCalculate).HasDefaultValueSql("((1))");

                entity.Property(e => e.KpiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LstValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiActionMasterIndex>(entity =>
            {
                entity.ToTable("KpiActionMasterIndex");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImplementPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KpiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LstValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Land, 2 Region, 3 MarketSegment, 4 Submarket, 5 subclient, 6 Product Group, 7 Product, 8 subProduct, 9 Maingoal, 10 subgoal");
            });

            modelBuilder.Entity<KpiActionMasterIndexTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiActionMasterIndexTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImplementPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KpiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LstValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Land, 2 Region, 3 MarketSegment, 4 Submarket, 5 subclient, 6 Product Group, 7 Product, 8 subProduct, 9 Maingoal, 10 subgoal");
            });

            modelBuilder.Entity<KpiActionMasterIndexTime>(entity =>
            {
                entity.ToTable("KpiActionMasterIndexTime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiActionMasterIndexTimeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiActionMasterIndexTimeTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiActionMasterTime>(entity =>
            {
                entity.ToTable("KpiActionMasterTime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiActionMasterTimeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiActionMasterTimeTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiActionMasterTopic>(entity =>
            {
                entity.ToTable("KpiActionMasterTopic");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.TypeId).HasComment("Land/Region: 1, Market: 2, Product: 3, Goal: 4");
            });

            modelBuilder.Entity<KpiActionMasterTopicTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiActionMasterTopicTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.TypeId).HasComment("Land/Region: 1, Market: 2, Product: 3, Goal: 4");
            });

            modelBuilder.Entity<KpiFormat>(entity =>
            {
                entity.ToTable("KpiFormat");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<KpiFormatItem>(entity =>
            {
                entity.ToTable("KpiFormatItem");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex)
                    .HasColumnName("MIndex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mvalue).HasColumnName("MValue");
            });

            modelBuilder.Entity<KpiFormatItemValue>(entity =>
            {
                entity.ToTable("KpiFormatItemValue");

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FtypeId)
                    .HasColumnName("FTypeId")
                    .HasComment("1 Setting, 2 Action");

                entity.Property(e => e.Gid).HasColumnName("GId");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Org, 2 Person, 3 File");
            });

            modelBuilder.Entity<KpiFormatItemValueTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiFormatItemValueTemp");

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FtypeId).HasColumnName("FTypeId");

                entity.Property(e => e.Gid).HasColumnName("GId");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiFormatType>(entity =>
            {
                entity.ToTable("KpiFormatType");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<KpiGoalIndex>(entity =>
            {
                entity.ToTable("KpiGoalIndex");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImplementPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsCalculate).HasDefaultValueSql("((1))");

                entity.Property(e => e.KpiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LstValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("1 Land, 2 Region, 3 MarketSegment, 4 Submarket, 5 subclient, 6 Product Group, 7 Product, 8 subProduct, 9 Maingoal, 10 Subgoal");
            });

            modelBuilder.Entity<KpiGoalIndexLink>(entity =>
            {
                entity.ToTable("KpiGoalIndexLink");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasComment("3. Marketsegment, 4 Submarket, 5 Subclient, 6 ProductGroup, 7 Product, 8 SubProduct");
            });

            modelBuilder.Entity<KpiGoalIndexLinkTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiGoalIndexLinkTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiGoalIndexTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiGoalIndexTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImplementPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsCalculate).HasDefaultValueSql("((1))");

                entity.Property(e => e.KpiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LstValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiGoalIndexTime>(entity =>
            {
                entity.ToTable("KpiGoalIndexTime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiGoalIndexTimeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiGoalIndexTimeTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiGoalTime>(entity =>
            {
                entity.ToTable("KpiGoalTime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiGoalTimeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiGoalTimeTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiGoalTopic>(entity =>
            {
                entity.ToTable("KpiGoalTopic");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.TypeId).HasComment("Land/Region: 1, Market: 2, Product: 3, Goal: 4");
            });

            modelBuilder.Entity<KpiGoalTopicTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiGoalTopicTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<KpiIndex>(entity =>
            {
                entity.ToTable("KpiIndex");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiTimeId).HasComment("in category table, type: 18");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<KpiOutcomeIndexTime>(entity =>
            {
                entity.ToTable("KpiOutcomeIndexTime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiOutcomeIndexTimeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiOutcomeIndexTimeTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.KpiValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiOutcomeTime>(entity =>
            {
                entity.ToTable("KpiOutcomeTime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsAuto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiOutcomeTimeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KpiOutcomeTimeTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiSettingIndex>(entity =>
            {
                entity.ToTable("KpiSettingIndex");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsKpiDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KpiTopic>(entity =>
            {
                entity.ToTable("KpiTopic");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<KpiUnit>(entity =>
            {
                entity.ToTable("KpiUnit");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OrderId).HasComment("1 front, 2 behind ");

                entity.Property(e => e.PositionId).HasComment("1:left, 2: right, 3: center");

                entity.Property(e => e.Symbol).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasComment("1. Number, 2 Currency, 3 Percent, 4 Index, 5 m2, 6 Hour");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("Label");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Labels)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Label_Project");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Labels)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Label_Region");
            });

            modelBuilder.Entity<Land>(entity =>
            {
                entity.ToTable("Land");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasComment("1: New, 2 Old");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Lands)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Land_Project");
            });

            modelBuilder.Entity<LandCostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Land_CostView");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Language).HasMaxLength(10);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<MTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mTest");
            });

            modelBuilder.Entity<MainGoal>(entity =>
            {
                entity.ToTable("MainGoal");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Budget).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Finish).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCalendar).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mcolor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MColor");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Independency)
                    .WithMany(p => p.MainGoals)
                    .HasForeignKey(d => d.IndependencyId)
                    .HasConstraintName("FK_MainGoal_Independency");

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.MainGoals)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_MainGoal_SubMarketProduct");
            });

            modelBuilder.Entity<MainGoalFilter>(entity =>
            {
                entity.ToTable("MainGoalFilter");

                entity.Property(e => e.MainGoalIds).IsUnicode(false);
            });

            modelBuilder.Entity<MainGoalTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MainGoalTemp");

                entity.Property(e => e.Budget).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Finish).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Mcolor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MColor");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaingoalReminderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaingoalReminderView");
            });

            modelBuilder.Entity<MarketSegment>(entity =>
            {
                entity.ToTable("MarketSegment");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasComment("1: New, 2 Old");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.MarketSegments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_MarketSegment_Project");
            });

            modelBuilder.Entity<MarketSegmentCostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MarketSegment_CostView");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MarketSegmentRegion>(entity =>
            {
                entity.ToTable("MarketSegmentRegion");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StrategyId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MarketSegment)
                    .WithMany(p => p.MarketSegmentRegions)
                    .HasForeignKey(d => d.MarketSegmentId)
                    .HasConstraintName("FK_MarketSegmentRegion_MarketSegment");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.MarketSegmentRegions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketSegmentRegion_Region");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.MarketSegmentRegions)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MarketSegmentRegion_Template");
            });

            modelBuilder.Entity<MarketsegmentTitle>(entity =>
            {
                entity.ToTable("MarketsegmentTitle");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TitleName).HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("1 Marketsegment, 2 Land, 3 HeaderMarketsegment");
            });

            modelBuilder.Entity<MasterBudget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasterBudget");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mpercent)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("MPercent");
            });

            modelBuilder.Entity<Mtab>(entity =>
            {
                entity.ToTable("Mtab");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TypeId).HasComment("1 Market, 2 submarket, 3 Actionplan, 4 teamboard, 5 dashboard");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductGroupId)
                    .HasConstraintName("FK_Product_ProductGroup");
            });

            modelBuilder.Entity<ProductCompetition>(entity =>
            {
                entity.ToTable("ProductCompetition");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.Colors).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.ProductCompetitions)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_ProductCompetition_SubMarketProduct");
            });

            modelBuilder.Entity<ProductCompetitionTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductCompetitionTemp");

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.Colors).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductEvaluation>(entity =>
            {
                entity.ToTable("ProductEvaluation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Evaluation).HasComment("1: New, 2 Old");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.ProductEvaluations)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_ProductEvaluation_SubMarketProduct");
            });

            modelBuilder.Entity<ProductEvaluationTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductEvaluationTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductFinance>(entity =>
            {
                entity.ToTable("ProductFinance");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cost)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Income)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.ProductFinances)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_ProductFinance_SubMarketProduct");
            });

            modelBuilder.Entity<ProductFinanceTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductFinanceTemp");

                entity.Property(e => e.Cost)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Income)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.ToTable("ProductGroup");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsRelation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasComment("1: New, 2 Old");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProductGroups)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProductGroup_Project");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ProductGroups)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroup_Region");
            });

            modelBuilder.Entity<ProductPosition>(entity =>
            {
                entity.ToTable("ProductPosition");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Xname)
                    .HasMaxLength(100)
                    .HasColumnName("XName");

                entity.Property(e => e.Xunit).HasColumnName("XUnit");

                entity.Property(e => e.Yname)
                    .HasMaxLength(100)
                    .HasColumnName("YName");

                entity.Property(e => e.Yunit).HasColumnName("YUnit");

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.ProductPositions)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_ProductPosition_SubMarketProduct");
            });

            modelBuilder.Entity<ProductPositionChart>(entity =>
            {
                entity.ToTable("ProductPositionChart");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Xvalue).HasColumnName("XValue");

                entity.Property(e => e.Yvalue).HasColumnName("YValue");

                entity.HasOne(d => d.ProductPosition)
                    .WithMany(p => p.ProductPositionCharts)
                    .HasForeignKey(d => d.ProductPositionId)
                    .HasConstraintName("FK_ProductPositionChart_ProductPosition");
            });

            modelBuilder.Entity<ProductPositionChartTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductPositionChartTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Xvalue).HasColumnName("XValue");

                entity.Property(e => e.Yvalue).HasColumnName("YValue");
            });

            modelBuilder.Entity<ProductPositionTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductPositionTemp");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasComment("ID master template");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Xname)
                    .HasMaxLength(100)
                    .HasColumnName("XName");

                entity.Property(e => e.Xunit).HasColumnName("XUnit");

                entity.Property(e => e.Yname)
                    .HasMaxLength(100)
                    .HasColumnName("YName");

                entity.Property(e => e.Yunit).HasColumnName("YUnit");
            });

            modelBuilder.Entity<ProductSe>(entity =>
            {
                entity.ToTable("ProductSe");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("1: ProductGroup, 2: Product, 3: SubProduct");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndYear).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.IsApplyAllRegion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsHiddenGoalContent).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOverDue).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowMarketLabel).HasDefaultValueSql("((1))");

                entity.Property(e => e.Isxy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartYear).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.HasOne(d => d.ProjectGroup)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectGroupId)
                    .HasConstraintName("FK_Project_ProjectGroup");
            });

            modelBuilder.Entity<ProjectGroup>(entity =>
            {
                entity.ToTable("ProjectGroup");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectLanguage>(entity =>
            {
                entity.ToTable("ProjectLanguage");

                entity.Property(e => e.ClientKeyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LangId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectLanguages)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectLanguage_Project");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsMaster).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRelation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Land)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.LandId)
                    .HasConstraintName("FK_Region_Land");
            });

            modelBuilder.Entity<RegionCostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Region_CostView");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RegionEvaluation>(entity =>
            {
                entity.ToTable("RegionEvaluation");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Evaluation).HasComment("1: New, 2 Old");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MarketSegmentRegion)
                    .WithMany(p => p.RegionEvaluations)
                    .HasForeignKey(d => d.MarketSegmentRegionId)
                    .HasConstraintName("FK_RegionEvaluation_MarketSegmentRegion");
            });

            modelBuilder.Entity<RegionTitle>(entity =>
            {
                entity.ToTable("RegionTitle");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TitleName).HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("1. ProductGroup, 2 Submarket, 3 ProductSubmarket");
            });

            modelBuilder.Entity<ReportActionGetCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReportActionGetCategoryView");
            });

            modelBuilder.Entity<ReportGoalGetCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReportGoalGetCategoryView");
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.HasKey(e => e.FunctionCode)
                    .HasName("PK_Right_1");

                entity.ToTable("Right");

                entity.Property(e => e.FunctionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Type).HasComment("Type: 0 SystemRight, 1 GroupRight, 2 ProjectRight, 3 StrategyRight");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasComment("Type: 0 SystemRole, 1 GroupRole, 2 ProjectRole, 3 StrategyRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RoleRight>(entity =>
            {
                entity.ToTable("RoleRight");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FunctionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<StatusProtocol>(entity =>
            {
                entity.ToTable("StatusProtocol");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasComment("Join voi bang Categories thong qua CateId");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.StatusProtocols)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_StatusProtocol_Action");
            });

            modelBuilder.Entity<StatusProtocolGetByGoal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StatusProtocol_GetByGoal");

                entity.Property(e => e.GoalDate).HasColumnType("date");

                entity.Property(e => e.GoalStatus).HasMaxLength(200);

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<StatusProtocolTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StatusProtocolTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StatusProtocolViewByAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StatusProtocol_ViewByAction");

                entity.Property(e => e.ActionStatus).HasMaxLength(200);

                entity.Property(e => e.ActionStatusDate).HasColumnType("date");

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<Strategy>(entity =>
            {
                entity.ToTable("Strategy");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Type).HasComment("1: Marketingstategie, 2: CRM");
            });

            modelBuilder.Entity<SubClient>(entity =>
            {
                entity.ToTable("SubClient");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SubMarket>(entity =>
            {
                entity.ToTable("SubMarket");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsRelation).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSubClient).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MarketSegmentRegion)
                    .WithMany(p => p.SubMarkets)
                    .HasForeignKey(d => d.MarketSegmentRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarket_MarketSegmentRegion");
            });

            modelBuilder.Entity<SubMarketLabel>(entity =>
            {
                entity.ToTable("SubMarketLabel");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.SubMarketLabels)
                    .HasForeignKey(d => d.LabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarketLabel_Label");

                entity.HasOne(d => d.SubMarket)
                    .WithMany(p => p.SubMarketLabels)
                    .HasForeignKey(d => d.SubMarketId)
                    .HasConstraintName("FK_SubMarketLabel_SubMarket");
            });

            modelBuilder.Entity<SubMarketProduct>(entity =>
            {
                entity.ToTable("SubMarketProduct");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMasterGoalKpi).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNotRelative).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.EvaluationTemplate)
                    .WithMany(p => p.SubMarketProducts)
                    .HasForeignKey(d => d.EvaluationTemplateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SubMarketProduct_Template");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SubMarketProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SubMarketProduct_Product");

                entity.HasOne(d => d.SubMarket)
                    .WithMany(p => p.SubMarketProducts)
                    .HasForeignKey(d => d.SubMarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarketProduct_SubMarket");
            });

            modelBuilder.Entity<SubMarketProductAccount>(entity =>
            {
                entity.ToTable("SubMarketProductAccount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SubMarketProductAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarketProductAccount_Account");

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.SubMarketProductAccounts)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarketProductAccount_SubMarketProduct");
            });

            modelBuilder.Entity<SubMarketProductAccountTemp>(entity =>
            {
                entity.ToTable("SubMarketProductAccountTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubMarketProductTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubMarketProductTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubMarketSe>(entity =>
            {
                entity.ToTable("SubMarketSe");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("1: Marketsegment, 2: Submarket, 3: Subclient");
            });

            modelBuilder.Entity<SubProduct>(entity =>
            {
                entity.ToTable("SubProduct");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SubSwotanalyse>(entity =>
            {
                entity.ToTable("SubSwotanalyse");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Swotanalyse)
                    .WithMany(p => p.SubSwotanalyses)
                    .HasForeignKey(d => d.SwotanalyseId)
                    .HasConstraintName("FK_SubSwotanalyse_Swotanalyse");
            });

            modelBuilder.Entity<SubSwotanalyseTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubSwotanalyseTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SubmarketCountEval>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Submarket_CountEval");

                entity.Property(e => e.Ecount).HasColumnName("ECount");
            });

            modelBuilder.Entity<SubmarketProductCountEval>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubmarketProduct_CountEval");
            });

            modelBuilder.Entity<SwotTemplate>(entity =>
            {
                entity.ToTable("SwotTemplate");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SwotTemplateAccount>(entity =>
            {
                entity.ToTable("SwotTemplateAccount");
            });

            modelBuilder.Entity<Swotanalyse>(entity =>
            {
                entity.ToTable("Swotanalyse");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SwotanalyseTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SwotanalyseTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TargetGroup>(entity =>
            {
                entity.ToTable("TargetGroup");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.TargetGroups)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .HasConstraintName("FK_TargetGroup_SubMarketProduct");
            });

            modelBuilder.Entity<TargetGroupTemp>(entity =>
            {
                entity.ToTable("TargetGroupTemp");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.TargetGroupTemps)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_TargetGroupTemp_Template");
            });

            modelBuilder.Entity<TempFragenset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempFragenset");

                entity.Property(e => e.Id).HasComment("generate from AccountId");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PublicType).HasComment("0 Private, 1 Project, 2 All");

                entity.Property(e => e.Type).HasComment("0 marketRegion, 1 Product, 2 Competition, 3 Position, 4 Target, 5 Swotanalyse, 6 submarket, 7 maingoal, 8 subgoal, 9 action");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasComment("split by 3 chars: {@|");
            });

            modelBuilder.Entity<TodoAccount>(entity =>
            {
                entity.ToTable("TodoAccount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<TodoAccountTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TodoAccountTemp");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<VideoLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VideoLink");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
