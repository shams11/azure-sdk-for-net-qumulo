namespace Azure.ResourceManager.BillingBenefits
{
    public static partial class BillingBenefitsExtensions
    {
        public static Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource> GetBillingBenefitsReservationOrderAlias(this Azure.ResourceManager.Resources.TenantResource tenantResource, string reservationOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource>> GetBillingBenefitsReservationOrderAliasAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string reservationOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasCollection GetBillingBenefitsReservationOrderAliases(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource GetBillingBenefitsReservationOrderAliasResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> GetBillingBenefitsSavingsPlanOrder(this Azure.ResourceManager.Resources.TenantResource tenantResource, string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource> GetBillingBenefitsSavingsPlanOrderAlias(this Azure.ResourceManager.Resources.TenantResource tenantResource, string savingsPlanOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource>> GetBillingBenefitsSavingsPlanOrderAliasAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string savingsPlanOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasCollection GetBillingBenefitsSavingsPlanOrderAliases(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource GetBillingBenefitsSavingsPlanOrderAliasResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>> GetBillingBenefitsSavingsPlanOrderAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource GetBillingBenefitsSavingsPlanOrderResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderCollection GetBillingBenefitsSavingsPlanOrders(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource GetBillingBenefitsSavingsPlanResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlans(this Azure.ResourceManager.Resources.TenantResource tenantResource, string filter = null, string orderBy = null, string refreshSummary = null, float? skipToken = default(float?), string selectedState = null, float? take = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlansAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string filter = null, string orderBy = null, string refreshSummary = null, float? skipToken = default(float?), string selectedState = null, float? take = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.BillingBenefits.Models.SavingsPlanValidateResult> ValidatePurchase(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.BillingBenefits.Models.SavingsPlanPurchaseValidateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.BillingBenefits.Models.SavingsPlanValidateResult> ValidatePurchaseAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.BillingBenefits.Models.SavingsPlanPurchaseValidateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingBenefitsReservationOrderAliasCollection : Azure.ResourceManager.ArmCollection
    {
        protected BillingBenefitsReservationOrderAliasCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string reservationOrderAliasName, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservationOrderAliasCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string reservationOrderAliasName, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservationOrderAliasCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string reservationOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string reservationOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource> Get(string reservationOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource>> GetAsync(string reservationOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingBenefitsReservationOrderAliasData : Azure.ResourceManager.Models.ResourceData
    {
        public BillingBenefitsReservationOrderAliasData(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSku sku) { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingScopeId { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState? ProvisioningState { get { throw null; } }
        public int? Quantity { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ReservationOrderId { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility? ReservedResourceInstanceFlexibility { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType? ReservedResourceType { get { throw null; } set { } }
        public System.DateTimeOffset? ReviewOn { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm? Term { get { throw null; } set { } }
    }
    public partial class BillingBenefitsReservationOrderAliasResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingBenefitsReservationOrderAliasResource() { }
        public virtual Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string reservationOrderAliasName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservationOrderAliasCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsReservationOrderAliasResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservationOrderAliasCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingBenefitsSavingsPlanCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>, System.Collections.IEnumerable
    {
        protected BillingBenefitsSavingsPlanCollection() { }
        public virtual Azure.Response<bool> Exists(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> Get(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>> GetAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingBenefitsSavingsPlanData : Azure.ResourceManager.Models.ResourceData
    {
        public BillingBenefitsSavingsPlanData(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSku sku) { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public System.DateTimeOffset? BenefitStartOn { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingScopeId { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitment Commitment { get { throw null; } set { } }
        public string CustomerId { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public string DisplayProvisioningState { get { throw null; } }
        public System.DateTimeOffset? EffectOn { get { throw null; } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsExtendedStatusInfo ExtendedStatusInfo { get { throw null; } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState? ProvisioningState { get { throw null; } }
        public System.DateTimeOffset? PurchaseOn { get { throw null; } }
        public string RenewDestination { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPurchaseContent RenewPurchaseProperties { get { throw null; } set { } }
        public string RenewSource { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm? Term { get { throw null; } set { } }
        public string UserFriendlyAppliedScopeType { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSavingsPlanUtilization Utilization { get { throw null; } }
    }
    public partial class BillingBenefitsSavingsPlanOrderAliasCollection : Azure.ResourceManager.ArmCollection
    {
        protected BillingBenefitsSavingsPlanOrderAliasCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string savingsPlanOrderAliasName, Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string savingsPlanOrderAliasName, Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string savingsPlanOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string savingsPlanOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource> Get(string savingsPlanOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource>> GetAsync(string savingsPlanOrderAliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingBenefitsSavingsPlanOrderAliasData : Azure.ResourceManager.Models.ResourceData
    {
        public BillingBenefitsSavingsPlanOrderAliasData(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSku sku) { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingScopeId { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitment Commitment { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier SavingsPlanOrderId { get { throw null; } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm? Term { get { throw null; } set { } }
    }
    public partial class BillingBenefitsSavingsPlanOrderAliasResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingBenefitsSavingsPlanOrderAliasResource() { }
        public virtual Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string savingsPlanOrderAliasName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingBenefitsSavingsPlanOrderCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>, System.Collections.IEnumerable
    {
        protected BillingBenefitsSavingsPlanOrderCollection() { }
        public virtual Azure.Response<bool> Exists(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> Get(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>> GetAsync(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingBenefitsSavingsPlanOrderData : Azure.ResourceManager.Models.ResourceData
    {
        public BillingBenefitsSavingsPlanOrderData(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSku sku) { }
        public System.DateTimeOffset? BenefitStartOn { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingScopeId { get { throw null; } set { } }
        public string CustomerId { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsExtendedStatusInfo ExtendedStatusInfo { get { throw null; } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingPlanInformation PlanInformation { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<string> SavingsPlans { get { throw null; } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm? Term { get { throw null; } set { } }
    }
    public partial class BillingBenefitsSavingsPlanOrderResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingBenefitsSavingsPlanOrderResource() { }
        public virtual Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string savingsPlanOrderId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsRoleAssignmentEntity> Elevate(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsRoleAssignmentEntity>> ElevateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlan(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>> GetBillingBenefitsSavingsPlanAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanCollection GetBillingBenefitsSavingsPlans() { throw null; }
    }
    public partial class BillingBenefitsSavingsPlanResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingBenefitsSavingsPlanResource() { }
        public virtual Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string savingsPlanOrderId, string savingsPlanId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource> Update(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSavingsPlanPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanResource>> UpdateAsync(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSavingsPlanPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.BillingBenefits.Models.SavingsPlanValidateResult> ValidateUpdate(Azure.ResourceManager.BillingBenefits.Models.SavingsPlanUpdateValidateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.BillingBenefits.Models.SavingsPlanValidateResult> ValidateUpdateAsync(Azure.ResourceManager.BillingBenefits.Models.SavingsPlanUpdateValidateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsAppliedScopeProperties
    {
        public BillingBenefitsAppliedScopeProperties() { }
        public string DisplayName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ManagementGroupId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceGroupId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SubscriptionId { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsAppliedScopeType : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsAppliedScopeType(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType ManagementGroup { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType Shared { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType Single { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsBillingPlan : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsBillingPlan(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan P1M { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingBenefitsCommitment : Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPrice
    {
        public BillingBenefitsCommitment() { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain? Grain { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsCommitmentGrain : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsCommitmentGrain(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain Hourly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitmentGrain right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingBenefitsExtendedStatusInfo
    {
        internal BillingBenefitsExtendedStatusInfo() { }
        public string Message { get { throw null; } }
        public string StatusCode { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsInstanceFlexibility : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsInstanceFlexibility(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility Off { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility On { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsPaymentStatus : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsPaymentStatus(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus Cancelled { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus Scheduled { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingBenefitsPrice
    {
        public BillingBenefitsPrice() { }
        public double? Amount { get { throw null; } set { } }
        public string CurrencyCode { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsProvisioningState : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState Cancelled { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState ConfirmedBilling { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState Created { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState Expired { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState PendingBilling { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingBenefitsPurchaseContent
    {
        public BillingBenefitsPurchaseContent() { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingScopeId { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsCommitment Commitment { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? EffectOn { get { throw null; } }
        public bool? IsRenewed { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm? Term { get { throw null; } set { } }
    }
    public partial class BillingBenefitsReservationOrderAliasCreateOrUpdateContent : Azure.ResourceManager.Models.ResourceData
    {
        public BillingBenefitsReservationOrderAliasCreateOrUpdateContent(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSku sku) { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingScopeId { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public int? Quantity { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsInstanceFlexibility? ReservedResourceInstanceFlexibility { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType? ReservedResourceType { get { throw null; } set { } }
        public System.DateTimeOffset? ReviewOn { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm? Term { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsReservedResourceType : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsReservedResourceType(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType AppService { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType Avs { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType AzureDataExplorer { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType AzureFiles { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType BlockBlob { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType CosmosDB { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType Databricks { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType DataFactory { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType DedicatedHost { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType ManagedDisk { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType MariaDB { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType MySql { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType NetAppStorage { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType PostgreSql { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType RedHat { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType RedHatOsa { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType RedisCache { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType SapHana { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType SqlAzureHybridBenefit { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType SqlDatabases { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType SqlDataWarehouse { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType SqlEdge { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType SuseLinux { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType VirtualMachines { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType VirtualMachineSoftware { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType VMwareCloudSimple { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsReservedResourceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingBenefitsRoleAssignmentEntity
    {
        internal BillingBenefitsRoleAssignmentEntity() { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public string Name { get { throw null; } }
        public string PrincipalId { get { throw null; } }
        public Azure.Core.ResourceIdentifier RoleDefinitionId { get { throw null; } }
        public Azure.Core.ResourceIdentifier Scope { get { throw null; } }
    }
    public partial class BillingBenefitsSavingsPlanPatch
    {
        public BillingBenefitsSavingsPlanPatch() { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSavingsPlanPatchProperties Properties { get { throw null; } set { } }
    }
    public partial class BillingBenefitsSavingsPlanPatchProperties
    {
        public BillingBenefitsSavingsPlanPatchProperties() { }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPurchaseContent RenewPurchaseProperties { get { throw null; } set { } }
    }
    public partial class BillingBenefitsSavingsPlanUtilization
    {
        internal BillingBenefitsSavingsPlanUtilization() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSavingsPlanUtilizationAggregate> Aggregates { get { throw null; } }
        public string Trend { get { throw null; } }
    }
    public partial class BillingBenefitsSavingsPlanUtilizationAggregate
    {
        internal BillingBenefitsSavingsPlanUtilizationAggregate() { }
        public float? Grain { get { throw null; } }
        public string GrainUnit { get { throw null; } }
        public float? Value { get { throw null; } }
        public string ValueUnit { get { throw null; } }
    }
    public partial class BillingBenefitsSku
    {
        public BillingBenefitsSku() { }
        public string Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitsTerm : System.IEquatable<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitsTerm(string value) { throw null; }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm P1Y { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm P3Y { get { throw null; } }
        public static Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm P5Y { get { throw null; } }
        public bool Equals(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm right) { throw null; }
        public static implicit operator Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm left, Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsTerm right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingPlanInformation
    {
        public BillingPlanInformation() { }
        public System.DateTimeOffset? NextPaymentDueOn { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPrice PricingCurrencyTotal { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.BillingBenefits.Models.SavingsPlanOrderPaymentDetail> Transactions { get { throw null; } }
    }
    public partial class SavingsPlanOrderPaymentDetail
    {
        public SavingsPlanOrderPaymentDetail() { }
        public string BillingAccount { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPrice BillingCurrencyTotal { get { throw null; } set { } }
        public System.DateTimeOffset? DueOn { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsExtendedStatusInfo ExtendedStatusInfo { get { throw null; } }
        public System.DateTimeOffset? PayOn { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPrice PricingCurrencyTotal { get { throw null; } set { } }
        public Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsPaymentStatus? Status { get { throw null; } set { } }
    }
    public partial class SavingsPlanPurchaseValidateContent
    {
        public SavingsPlanPurchaseValidateContent() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.BillingBenefits.BillingBenefitsSavingsPlanOrderAliasData> Benefits { get { throw null; } }
    }
    public partial class SavingsPlanUpdateValidateContent
    {
        public SavingsPlanUpdateValidateContent() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.BillingBenefits.Models.BillingBenefitsSavingsPlanPatchProperties> Benefits { get { throw null; } }
    }
    public partial class SavingsPlanValidateResult
    {
        internal SavingsPlanValidateResult() { }
        public bool? IsValid { get { throw null; } }
        public string Reason { get { throw null; } }
        public string ReasonCode { get { throw null; } }
    }
}
