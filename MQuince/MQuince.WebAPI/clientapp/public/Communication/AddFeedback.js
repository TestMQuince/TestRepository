var app = new Vue({
	el: '#addFeedback',
	data: {
		Comment: "",
		Anonymous: false,
		Publish: true
	},
	methods: {
		submit() {
			var name = "Anonymous"
			if (this.Anonymous == false)
				name = "Petar Petrovic"
			console.log(name)
			axios
				.post("/api/Feedback", {
					Comment: this.Comment,
					Anonymous: this.Anonymous,
					Publish: this.Publish,
					User: name
				}).then(response => {
					JSAlert.alert("Success!")
				})
        }
	}
})