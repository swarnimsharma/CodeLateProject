﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PortalEntities : DbContext
    {
        public PortalEntities()
            : base("name=PortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<portal_city> portal_city { get; set; }
        public virtual DbSet<portal_country> portal_country { get; set; }
        public virtual DbSet<portal_experience> portal_experience { get; set; }
        public virtual DbSet<portal_experise> portal_experise { get; set; }
        public virtual DbSet<portal_recruiter_profile> portal_recruiter_profile { get; set; }
        public virtual DbSet<portal_role> portal_role { get; set; }
        public virtual DbSet<portal_state> portal_state { get; set; }
        public virtual DbSet<portal_user> portal_user { get; set; }
        public virtual DbSet<portal_user_role_mapping> portal_user_role_mapping { get; set; }
        public virtual DbSet<portal_for_interested_Candidate> portal_for_interested_Candidate { get; set; }
        public virtual DbSet<portal_post_requirement> portal_post_requirement { get; set; }
        public virtual DbSet<portal_requirement_vendor_mapping> portal_requirement_vendor_mapping { get; set; }
        public virtual DbSet<portal_what_client_says> portal_what_client_says { get; set; }
        public virtual DbSet<portal_plan> portal_plan { get; set; }
        public virtual DbSet<portal_vendor_price_plan> portal_vendor_price_plan { get; set; }
        public virtual DbSet<portal_user_candidate_info> portal_user_candidate_info { get; set; }
        public virtual DbSet<portal_vendor_plan_mapping> portal_vendor_plan_mapping { get; set; }
        public virtual DbSet<portal_vendor_lead_access_mapping> portal_vendor_lead_access_mapping { get; set; }
        public virtual DbSet<portal_candidate_plan> portal_candidate_plan { get; set; }
        public virtual DbSet<portal_vendor_plan> portal_vendor_plan { get; set; }
        public virtual DbSet<portal_userplan_mapping> portal_userplan_mapping { get; set; }
        public virtual DbSet<portal_plan_duration_left> portal_plan_duration_left { get; set; }
    
        public virtual ObjectResult<portal_get_post_requirement_Result> portal_get_post_requirement(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<portal_get_post_requirement_Result>("portal_get_post_requirement", titleParameter);
        }
    
        public virtual ObjectResult<get_candidate_show_interest_by_client_Result> get_candidate_show_interest_by_client(Nullable<int> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_candidate_show_interest_by_client_Result>("get_candidate_show_interest_by_client", user_idParameter);
        }
    
        public virtual ObjectResult<portal_get_candidates_by_vendor_Result> portal_get_candidates_by_vendor(Nullable<int> user_id, string candidate_name, string technology, string experience)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var candidate_nameParameter = candidate_name != null ?
                new ObjectParameter("candidate_name", candidate_name) :
                new ObjectParameter("candidate_name", typeof(string));
    
            var technologyParameter = technology != null ?
                new ObjectParameter("technology", technology) :
                new ObjectParameter("technology", typeof(string));
    
            var experienceParameter = experience != null ?
                new ObjectParameter("experience", experience) :
                new ObjectParameter("experience", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<portal_get_candidates_by_vendor_Result>("portal_get_candidates_by_vendor", user_idParameter, candidate_nameParameter, technologyParameter, experienceParameter);
        }
    
        public virtual ObjectResult<portal_get_candidates_Result1> portal_get_candidates(string title, string locality, Nullable<int> fk_experience_id, Nullable<int> user_id, Nullable<int> job_type)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var localityParameter = locality != null ?
                new ObjectParameter("locality", locality) :
                new ObjectParameter("locality", typeof(string));
    
            var fk_experience_idParameter = fk_experience_id.HasValue ?
                new ObjectParameter("fk_experience_id", fk_experience_id) :
                new ObjectParameter("fk_experience_id", typeof(int));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var job_typeParameter = job_type.HasValue ?
                new ObjectParameter("job_type", job_type) :
                new ObjectParameter("job_type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<portal_get_candidates_Result1>("portal_get_candidates", titleParameter, localityParameter, fk_experience_idParameter, user_idParameter, job_typeParameter);
        }
    
        public virtual ObjectResult<portal_get_cities_by_state_Result> portal_get_cities_by_state(Nullable<int> state_id, string state_ids, string search)
        {
            var state_idParameter = state_id.HasValue ?
                new ObjectParameter("state_id", state_id) :
                new ObjectParameter("state_id", typeof(int));
    
            var state_idsParameter = state_ids != null ?
                new ObjectParameter("state_ids", state_ids) :
                new ObjectParameter("state_ids", typeof(string));
    
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<portal_get_cities_by_state_Result>("portal_get_cities_by_state", state_idParameter, state_idsParameter, searchParameter);
        }
    
        public virtual ObjectResult<portal_get_states_by_country_Result> portal_get_states_by_country(Nullable<int> country_id, string country_ids)
        {
            var country_idParameter = country_id.HasValue ?
                new ObjectParameter("country_id", country_id) :
                new ObjectParameter("country_id", typeof(int));
    
            var country_idsParameter = country_ids != null ?
                new ObjectParameter("country_ids", country_ids) :
                new ObjectParameter("country_ids", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<portal_get_states_by_country_Result>("portal_get_states_by_country", country_idParameter, country_idsParameter);
        }
    
        [DbFunction("PortalEntities", "portal_SplitString")]
        public virtual IQueryable<string> portal_SplitString(string @string, string delimiter)
        {
            var stringParameter = @string != null ?
                new ObjectParameter("string", @string) :
                new ObjectParameter("string", typeof(string));
    
            var delimiterParameter = delimiter != null ?
                new ObjectParameter("delimiter", delimiter) :
                new ObjectParameter("delimiter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<string>("[PortalEntities].[portal_SplitString](@string, @delimiter)", stringParameter, delimiterParameter);
        }
    
        public virtual ObjectResult<getActivateCandidatePlan_Result> getActivateCandidatePlan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getActivateCandidatePlan_Result>("getActivateCandidatePlan");
        }
    
        public virtual ObjectResult<getIsApprovedCandidatePlans_Result> getIsApprovedCandidatePlans()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getIsApprovedCandidatePlans_Result>("getIsApprovedCandidatePlans");
        }
    }
}
