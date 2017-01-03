using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBOTool.Models
{
    public class WellDetail
    {
        private const string DateFormatString = "{0:MM/dd/yyyy}";

        public int Id { get; set; }

        public string Commenter { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Comment Date")]
        public DateTime CommentDate { get; set; }

        #region WellData

        [DisplayName("Well Name")]
        public string Name { get; set; }
        [DisplayName("API Number")]
        public string ApiNumber { get; set; }
        [DisplayName("Well DUWI-A")]
        public string Duwi { get; set; }
        [DisplayName("Business Unit")]
        public int? BusinessUnitId { get; set; }
        [DisplayName("Field Name")]
        public string FieldName { get; set; }
        [DisplayName("Partner AFE #")]
        public string PartnerAfe { get; set; }
        public string Operator { get; set; }
        [DisplayName("Election")]
        public int? ElectionId { get; set; }
        public string County { get; set; }
        public string State { get; set; }//Lookup
        [MaxLength(2)]
        public string Section { get; set; }
        public string Township { get; set; }
        public string Range { get; set; }
        public string Datum { get; set; }//Lookup
        [Range(-90, 90)]
        public double? Latitude { get; set; }
        [Range(-180, 180)]
        public double? Longitude { get; set; }

        #endregion

        #region Proposed Section

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Estimated Spud Date")]
        public DateTime? ProposedEstimatedSpudDate { get; set; }

        #region WellType

        [DisplayName("Formation")]
        public string ProposedFormation { get; set; }

        [DisplayName("# Csg Strings")]
        public string ProposedNumberOfCsgStrings { get; set; }

        [DisplayName("String 1 Depth")]
        public double? ProposedStringOneDepth { get; set; }

        [DisplayName("String 1 Description")]
        public string ProposedStringOneDescription { get; set; }

        [DisplayName("String 2 Depth")]
        public double? ProposedStringTwoDepth { get; set; }

        [DisplayName("String 2 Description")]
        public string ProposedStringTwoDescription { get; set; }

        [DisplayName("String 3 Depth")]
        public double? ProposedStringThreeDepth { get; set; }

        [DisplayName("String 3 Description")]
        public string ProposedStringThreeDescription { get; set; }

        [DisplayName("String 4 Depth")]
        public double? ProposedStringFourDepth { get; set; }

        [DisplayName("String 4 Description")]
        public string ProposedStringFourDescription { get; set; }
        #endregion

        #region Performance

        [DisplayName("Plan Days")]
        public int? ProposedPlanDays { get; set; }

        [DisplayName("AFE Cost")]
        [DataType(DataType.Currency)]
        public double? ProposedAfeCost { get; set; }

        [DisplayName("Includes Construction?")]
        public bool ProposedIncludesConstruction { get; set; }

        [DisplayName("Includes Rig Move?")]
        public bool ProposedIncludesRigMove { get; set; }

        [DisplayName("Includes Prod Csg/Cmt?")]
        public bool ProposedIncludesProdCsgCmt { get; set; }

        #endregion

        #region Continuity

        [DisplayName("Batch Drilling?")]
        public bool ProposedBatchDrilling { get; set; }

        [DisplayName("Spudder Rig?")]
        public bool ProposedSpudderRig { get; set; }

        #endregion

        #region Drilling Strategy

        [DisplayName("Total Depth")]
        public double? ProposedTotalDepth { get; set; }
        [DisplayName("TVD")]
        public string ProposedTvd { get; set; }
        [DisplayName("Lateral Length")]
        public string ProposedLateralLength { get; set; }
        [DisplayName("Using RSS?")]
        public bool ProposedUsingRss { get; set; }

        #endregion

        [DisplayName("Mud Comments")]
        public string ProposedMudComments { get; set; }
        [DisplayName("Other Comments")]
        public string ProposedOtherComments { get; set; }

        #endregion

        #region Post Drill Section 
        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Spud Date")]
        public DateTime? PostDrillSpudDate { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("RR Date")]
        public DateTime? PostDrillRRDate { get; set; }

        #region WellType

        [DisplayName("Formation")]
        public string PostDrillFormation { get; set; }

        [DisplayName("# Csg Strings")]
        public string PostDrillNumberOfCsgStrings { get; set; }

        [DisplayName("String 1 Depth")]
        public double? PostDrillStringOneDepth { get; set; }

        [DisplayName("String 1 Description")]
        public string PostDrillStringOneDescription { get; set; }

        [DisplayName("String 2 Depth")]
        public double? PostDrillStringTwoDepth { get; set; }

        [DisplayName("String 2 Description")]
        public string PostDrillStringTwoDescription { get; set; }

        [DisplayName("String 3 Depth")]
        public double? PostDrillStringThreeDepth { get; set; }

        [DisplayName("String 3 Description")]
        public string PostDrillStringThreeDescription { get; set; }

        [DisplayName("String 4 Depth")]
        public double? PostDrillStringFourDepth { get; set; }

        [DisplayName("String 4 Description")]
        public string PostDrillStringFourDescription { get; set; }
        #endregion

        #region Performance

        [DisplayName("Drilling Days")]
        public int? PostDrillDrillingDays { get; set; }

        [DisplayName("Field Estimate")]
        public double? PostDrillFieldEstimate { get; set; }

        //[DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        [DisplayName("Actual Cost")]
        public double? PostDrillActualCost { get; set; }

        [DisplayName("Includes Construction?")]
        public bool PostDrillIncludesConstruction { get; set; }

        [DisplayName("Includes Rig Move?")]
        public bool PostDrillIncludesRigMove { get; set; }

        [DisplayName("Includes Prod Csg/Cmt?")]
        public bool PostDrillIncludesProdCsgCmt { get; set; }

        [DisplayName("Sidetrack?")]
        public bool PostDrillSidetrack { get; set; }

        #endregion

        #region Continuity

        [DisplayName("Batch Drilling?")]
        public bool PostDrillBatchDrilling { get; set; }

        [DisplayName("Spudder Rig?")]
        public bool PostDrillSpudderRig { get; set; }

        #endregion

        #region Drilling Strategy

        [DisplayName("Total Depth")]
        public double? PostDrillTotalDepth { get; set; }
        [DisplayName("TVD")]
        public string PostDrillTvd { get; set; }
        [DisplayName("Lateral Length")]
        public double? PostDrillLateralLength { get; set; }
        [DisplayName("Using RSS?")]
        public bool PostDrillUsingRss { get; set; }

        #endregion

        [DisplayName("Mud Comments")]
        public string PostDrillMudComments { get; set; }

        [DisplayName("Other Comments")]
        public string PostDrillOtherComments { get; set; }

        #endregion

        #region WDRF

        [DisplayName("Proposal Letter?")]
        public bool ProposalLetter { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Proposal Letter Date")]
        public DateTime? ProposalLetterDate { get; set; }

        [DisplayName("Election Letter?")]
        public bool ElectionLetter { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Election Letter Date")]
        public DateTime? ElectionLetterDate { get; set; }

        [DisplayName("Daily Drilling Report?")]
        public bool DailyDrillingReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Daily Drilling Report Date")]
        public DateTime? DailyDrillingReportDate { get; set; }

        [DisplayName("Final Directional Survey?")]
        public bool FinalDirectionalSurvey { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Final Directional Survey Date")]
        public DateTime? FinalDirectionalSurveyDate { get; set; }

        [DisplayName("Open hole, cased hole, & processed logs?")]
        public bool OpenHoleCasedHoleProcessedLogs { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Open hole, cased hole, & processed logs Date")]
        public DateTime? OpenHoleCasedHoleProcessedLogsDate { get; set; }

        [DisplayName("Final MWD?")]
        public bool FinalMwd { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Final MWD Date")]
        public DateTime? FinalMwdDate { get; set; }

        [DisplayName("Mudlog Final Update (manned and unmanned)?")]
        public bool MudlogFinalUpdate { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Mudlog Final Update (manned and unmanned) Date")]
        public DateTime? MudlogFinalUpdateDate { get; set; }

        [DisplayName("Core Reports, analyses and all related data (whole or sidewall core)?")]
        public bool CoreReportsAnalysesAllRelatedData { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Core Reports, analyses and all related data (whole or sidewall core) Date")]
        public DateTime? CoreReportsAnalysesAllRelatedDataDate { get; set; }

        [DisplayName("Daily Completion Report?")]
        public bool DailyCompletionReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Daily Completion Report Date")]
        public DateTime? DailyCompletionReportDate { get; set; }

        [DisplayName("Post Frac Report or Post Completion Report?")]
        public bool PostFracReportOrPostCompletionReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Post Frac Report or Post Completion Report Date")]
        public DateTime? PostFracReportOrPostCompletionReportDate { get; set; }

        [DisplayName("Flowback Report?")]
        public bool FlowbackReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Flowback Report Date")]
        public DateTime? FlowbackReportDate { get; set; }

        [DisplayName("Additional Product Testing?")]
        public bool AdditionalProductTesting { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Additional Product Testing Date")]
        public DateTime? AdditionalProductTestingDate { get; set; }

        [DisplayName("Drill Stem Reports?")]
        public bool DrillStemReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Drill Stem Reports Date")]
        public DateTime? DrillStemReportDate { get; set; }

        [DisplayName("Daily Production Reports?")]
        public bool DailyProductionReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Daily Production Reports Date")]
        public DateTime? DailyProductionReportDate { get; set; }

        [DisplayName("Monthly Production Reports?")]
        public bool MonthlyProductionReport { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Monthly Production Reports Date")]
        public DateTime? MonthlyProductionReportDate { get; set; }

        [DisplayName("Copy of Fully Executed Gas Contract?")]
        public bool CopyOfGasContract { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Copy of Fully Executed Gas Contract Date")]
        public DateTime? CopyOfGasContractDate { get; set; }

        [DisplayName("Fully Executed State and Federal Forms?")]
        public bool FullyExecutedStateAndFederalForms { get; set; }

        [DisplayFormat(DataFormatString = DateFormatString, ApplyFormatInEditMode = true)]
        [DisplayName("Fully Executed State and Federal Forms Date")]
        public DateTime? FullyExecutedStateAndFederalFormsDate { get; set; }

        #endregion

        public virtual BusinessUnit BusinessUnit { get; set; }
        public virtual Election Election { get; set; }
    }
}