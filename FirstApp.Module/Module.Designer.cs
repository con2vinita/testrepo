namespace FirstApp.Module {
	partial class FirstAppModule {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            // 
            // FirstAppModule
            // 
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.BaseObject));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.FileData));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.FileAttachmentBase));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.User));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Person));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Role));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Party));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Address));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.PhoneNumber));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Xpo.XPCustomObject));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Xpo.XPBaseObject));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Xpo.PersistentBase));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Country));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.RoleBase));
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.PersistentPermission));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.SystemModule.SystemModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.AuditTrail.AuditTrailModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.CloneObject.CloneObjectModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ReportsV2.ReportsModuleV2));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.StateMachine.StateMachineModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Validation.ValidationModule));

		}

		#endregion
	}
}
