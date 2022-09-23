 define("ClientMessageBridge", ["ConfigurationConstants"],
    function(ConfigurationConstants) {
        return {
            messages: {
                "AddingTours": {
                    "mode": Terrasoft.MessageMode.BROADCAST,
                    "direction": Terrasoft.MessageDirectionType.PUBLISH
                }
            },
            methods: {
                init: function() {
                    this.callParent(arguments);
                    this.addMessageConfig({
                        sender: "AddingTours",
                        messageName: "AddingTours"
                    });
                
                }
            }
        };
    });