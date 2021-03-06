﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEIaPP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PEIEntities7 : DbContext
    {
        public PEIEntities7()
            : base("name=PEIEntities7")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Alabama_AMatrix> Alabama_AMatrix { get; set; }
        public DbSet<Alabama_Area> Alabama_Area { get; set; }
        public DbSet<Alabama_DefaultData> Alabama_DefaultData { get; set; }
        public DbSet<Alabama_GridAlabama_RegionData> Alabama_GridAlabama_RegionData { get; set; }
        public DbSet<Alabama_GridRegionValues> Alabama_GridRegionValues { get; set; }
        public DbSet<Alabama_LeontievInverse> Alabama_LeontievInverse { get; set; }
        public DbSet<Alabama_RegionData> Alabama_RegionData { get; set; }
        public DbSet<Alabama_Regions> Alabama_Regions { get; set; }
        public DbSet<AlabamaRest_Area> AlabamaRest_Area { get; set; }
        public DbSet<AlabamaRest_DefaultData> AlabamaRest_DefaultData { get; set; }
        public DbSet<AlabamaRest_GridRegionValues> AlabamaRest_GridRegionValues { get; set; }
        public DbSet<AlabamaRest_LeontievInverse> AlabamaRest_LeontievInverse { get; set; }
        public DbSet<AlabamaRest_RegionData> AlabamaRest_RegionData { get; set; }
        public DbSet<Camping> Campings { get; set; }
        public DbSet<Day_Trip> Day_Trips { get; set; }
        public DbSet<DefaultData> DefaultDatas { get; set; }
        public DbSet<Distribution> Distributions { get; set; }
        public DbSet<DistributionCheckTbl> DistributionCheckTbls { get; set; }
        public DbSet<Friends_and_Family> Friends_and_Families { get; set; }
        public DbSet<FTE> FTEs { get; set; }
        public DbSet<GeneralInfo> GeneralInfoes { get; set; }
        public DbSet<I_O_Codes_Old> I_O_Codes_Old { get; set; }
        public DbSet<iocodes_new> iocodes_new { get; set; }
        public DbSet<JointVenture> JointVentures { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<MCapital> MCapitals { get; set; }
        public DbSet<MTheRest> MTheRests { get; set; }
        public DbSet<MTourism> MTourism { get; set; }
        public DbSet<Nation_Area> Nation_Area { get; set; }
        public DbSet<OccupationDistribution> OccupationDistributions { get; set; }
        public DbSet<P_nation_> P_nation_ { get; set; }
        public DbSet<RegionalData> RegionalDatas { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Rehab> Rehabs { get; set; }
        public DbSet<tblBase> tblBases { get; set; }
        public DbSet<tblDirectEffect> tblDirectEffects { get; set; }
        public DbSet<tblEconomicBase> tblEconomicBases { get; set; }
        public DbSet<tblGeneralIndustry> tblGeneralIndustries { get; set; }
        public DbSet<tblIndustry> tblIndustries { get; set; }
        public DbSet<tblOccupation> tblOccupations { get; set; }
        public DbSet<tblShare> tblShares { get; set; }
        public DbSet<tblTemp> tblTemps { get; set; }
        public DbSet<TempPC> TempPCs { get; set; }
        public DbSet<VectorAA> VectorAAs { get; set; }
        public DbSet<VectorAADistribution> VectorAADistributions { get; set; }
        public DbSet<z_AlabamaRest_AMatrix> z_AlabamaRest_AMatrix { get; set; }
        public DbSet<ZNewIoCode> ZNewIoCodes { get; set; }
        public DbSet<New_Stores_and_Restaurant> New_Stores_and_Restaurants { get; set; }
        public DbSet<History> Histories { get; set; }
    
        public virtual ObjectResult<Alabama_AMatrix> spAlabama_AMatrix(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_AMatrix>("spAlabama_AMatrix", tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_AMatrix> spAlabama_AMatrix(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_AMatrix>("spAlabama_AMatrix", mergeOption, tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_Area> spAlabama_Area(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_Area>("spAlabama_Area", tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_Area> spAlabama_Area(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_Area>("spAlabama_Area", mergeOption, tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_DefaultData> spAlabama_DefaultData(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_DefaultData>("spAlabama_DefaultData", tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_DefaultData> spAlabama_DefaultData(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_DefaultData>("spAlabama_DefaultData", mergeOption, tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_LeontievInverse> spAlabama_LeontievInverse(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_LeontievInverse>("spAlabama_LeontievInverse", tnameParameter);
        }
    
        public virtual ObjectResult<Alabama_LeontievInverse> spAlabama_LeontievInverse(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Alabama_LeontievInverse>("spAlabama_LeontievInverse", mergeOption, tnameParameter);
        }
    
        public virtual ObjectResult<AlabamaRest_Area> spAlabamaRest_Area(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlabamaRest_Area>("spAlabamaRest_Area", tnameParameter);
        }
    
        public virtual ObjectResult<AlabamaRest_Area> spAlabamaRest_Area(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlabamaRest_Area>("spAlabamaRest_Area", mergeOption, tnameParameter);
        }
    
        public virtual ObjectResult<AlabamaRest_DefaultData> spAlabamaRest_DefaultData(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlabamaRest_DefaultData>("spAlabamaRest_DefaultData", tnameParameter);
        }
    
        public virtual ObjectResult<AlabamaRest_DefaultData> spAlabamaRest_DefaultData(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlabamaRest_DefaultData>("spAlabamaRest_DefaultData", mergeOption, tnameParameter);
        }
    
        public virtual ObjectResult<z_AlabamaRest_AMatrix> spz_AlabamaRest_AMatrix(string tname)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<z_AlabamaRest_AMatrix>("spz_AlabamaRest_AMatrix", tnameParameter);
        }
    
        public virtual ObjectResult<z_AlabamaRest_AMatrix> spz_AlabamaRest_AMatrix(string tname, MergeOption mergeOption)
        {
            var tnameParameter = tname != null ?
                new ObjectParameter("tname", tname) :
                new ObjectParameter("tname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<z_AlabamaRest_AMatrix>("spz_AlabamaRest_AMatrix", mergeOption, tnameParameter);
        }
    }
}
