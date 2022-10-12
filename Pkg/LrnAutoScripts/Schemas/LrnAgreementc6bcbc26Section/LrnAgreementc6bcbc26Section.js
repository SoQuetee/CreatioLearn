 define("LrnAgreementc6bcbc26Section", ["ServiceHelper"], function(ServiceHelper) {
    return {
        /* The name of the section entity schema. */
        entitySchemaName: "LrnAgreement",
        methods: {
			
             /**
			  * обработка клика по кнопке "Выписка по договору"
			  */
			 onGetAgreementExtractClick: function() {
				let id = this.$ActiveRow;
				let serviceData = {
					agreementId: id
				};
				ServiceHelper.callService("AgreementExtract", "GetAgreementExtractFile",
				function(response) {
					let result = response.GetAgreementExtractFileResult;
					if (result) {
						let file = new File([new Uint8Array(result.FileContent)], result.FileName);
						const url = window.URL.createObjectURL(file);
						const a = document.createElement('a');
						a.style.display = "none";
						a.href = url;
						a.download = result.FileName;
						document.body.appendChild(a);
						a.click();
						window.URL.revokeObjectURL(url);
					}
				}, serviceData, this);
			 },
			
			 /**
			 * условия активности кнопки "Выписка по договору"
			 * @returns состояние активности кнопки
			 */
			 isAgreementDataSet: function() {
				return true
			 },
        },
			
        diff: /**SCHEMA_DIFF*/[
            {
                "operation": "insert",
                "parentName": "CombinedModeActionButtonsCardLeftContainer",
                "propertyName": "items",
                "name": "GetAgreementExtractButton",
                "values": {
                    "itemType": Terrasoft.ViewItemType.BUTTON,
                    "caption": {bindTo: "Resources.Strings.AgreementExtractButton"},
                    "click": {bindTo: "onGetAgreementExtractClick"},
                    "style": Terrasoft.controls.ButtonEnums.style.GREEN,
                    "enabled": {bindTo: "isAgreementDataSet"}
                }
            }
        ]/**SCHEMA_DIFF*/
    };
});