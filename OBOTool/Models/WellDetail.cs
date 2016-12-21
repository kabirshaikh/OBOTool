using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBOTool.Models
{
    public class WellDetail
    {
        public int Id { get; set; }

        public string Commenter { get; set; }

        [DisplayName("Comment Date")]
        public DateTime? CommentDate { get; set; }

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

        public string ProposedMudComments { get; set; }
        public string ProposedOtherComments { get; set; }

        #endregion

        #region Post Drill Section 
        [DisplayName("Spud Date")]
        public DateTime? PostDrillSpudDate { get; set; }
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

        [DisplayName("Plan Days")]
        public int? PostDrillDrillingDays { get; set; }

        [DisplayName("Field Estimate")]
        public double? PostDrillFieldEstimate { get; set; }

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

        public string PostDrillMudComments { get; set; }
        public string PostDrillOtherComments { get; set; }

        #endregion

        public virtual BusinessUnit BusinessUnit { get; set; }
        public virtual Election Election { get; set; }
    }
}