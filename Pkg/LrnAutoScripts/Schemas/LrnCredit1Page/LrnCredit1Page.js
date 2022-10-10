 define("LrnCredit1Page", ["ConfigurationConstants"], function(ConfigurationConstants) {
	return {
		entitySchemaName: "LrnCredit",
		methods: {
			setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("LrnDateEnd", this.finishDateValidator);
			},
			
			finishDateValidator: function() {
				let invalidMessage = "";
				let startDate = this.$LrnDateStart;
				let finishDate = this.$LrnDateEnd;

				if(startDate) {
					let startDateAddYear = new Date(startDate.getFullYear() + 1, startDate.getMonth(), startDate.getDate());
					if (startDateAddYear.getTime() > finishDate.getTime()) {
						invalidMessage = "Дата окончания должна быть больше даты начала не менее, чем на год!";
					}
				} 
				return {
					invalidMessage: invalidMessage
				};
			}
		}
	};
 });