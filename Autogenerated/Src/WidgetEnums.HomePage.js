  define("WidgetEnums", ["WidgetEnumsResources"], function(resources) {

	Ext.ns("Terrasoft.WidgetEnums");

	Terrasoft.WidgetEnums.WidgetColorSet = [
		"green",
		"dark-turquoise",
		"violet",
		"coral",
		"navy-blue",
		"red",
		"purple",
		"blue",
		"light-green",
		"dark-green",
		"orange",
		"orange-red",
		"bright-red",
		"celestial-blue",
		"light-blue",
		"turquoise",
	];

	Terrasoft.WidgetEnums.WidgetColor = {
		"light-green": {
			value: "light-green",
			displayValue: resources.localizableStrings.StyleLightGreen,
			imageConfig: resources.localizableImages.ImageLightGreen
		},
		"green": {
			value: "green",
			displayValue: resources.localizableStrings.StyleGreen,
			imageConfig: resources.localizableImages.ImageGreen
		},
		"dark-green": {
			value: "dark-green",
			displayValue: resources.localizableStrings.StyleDarkGreen,
			imageConfig: resources.localizableImages.ImageDarkGreen
		},
		"orange": {
			value: "orange",
			displayValue: resources.localizableStrings.StyleOrange,
			imageConfig: resources.localizableImages.ImageOrange
		},
		"orange-red": {
			value: "orange-red",
			displayValue: resources.localizableStrings.StyleOrangeRed,
			imageConfig: resources.localizableImages.ImageOrangeRed
		},
		"coral": {
			value: "coral",
			displayValue: resources.localizableStrings.StyleCoral,
			imageConfig: resources.localizableImages.ImageCoral
		},
		"bright-red": {
			value: "bright-red",
			displayValue: resources.localizableStrings.StyleBrightRed,
			imageConfig: resources.localizableImages.ImageBrightRed
		},
		"red": {
			value: "red",
			displayValue: resources.localizableStrings.StyleRed,
			imageConfig: resources.localizableImages.ImageRed
		},
		"purple": {
			value: "purple",
			displayValue: resources.localizableStrings.StylePurple,
			imageConfig: resources.localizableImages.ImagePurple
		},
		"violet": {
			value: "violet",
			displayValue: resources.localizableStrings.StyleViolet,
			imageConfig: resources.localizableImages.ImageViolet
		},
		"celestial-blue": {
			value: "celestial-blue",
			displayValue: resources.localizableStrings.StyleCelestialBlue,
			imageConfig: resources.localizableImages.ImageCelestialBlue
		},
		"blue": {
			value: "blue",
			displayValue: resources.localizableStrings.StyleBlue,
			imageConfig: resources.localizableImages.ImageBlue
		},
		"light-blue": {
			value: "light-blue",
			displayValue: resources.localizableStrings.StyleLightBlue,
			imageConfig: resources.localizableImages.ImageLightBlue
		},
		"navy-blue": {
			value: "navy-blue",
			displayValue: resources.localizableStrings.StyleNavyBlue,
			imageConfig: resources.localizableImages.ImageNavyBlue
		},
		"dark-turquoise": {
			value: "dark-turquoise",
			displayValue: resources.localizableStrings.StyleDarkTurquoise,
			imageConfig: resources.localizableImages.ImageDarkTurquoise
		},
		"turquoise": {
			value: "turquoise",
			displayValue: resources.localizableStrings.StyleTurquoise,
			imageConfig: resources.localizableImages.ImageTurquoise
		},
	};

	Terrasoft.WidgetEnums.WidgetTheme = {
		"full-fill": {
			value: "full-fill",
			displayValue: resources.localizableStrings.FullFillTheme
		},
		"without-fill": {
			value: "without-fill",
			displayValue: resources.localizableStrings.WithoutFillTheme
		},
		"partial-fill": {
			value: "partial-fill",
			displayValue: resources.localizableStrings.PartialFillTheme
		},
	};
});
