var app = new Vue({
	el: '#addFeedback',
	data: {
		Comment: "",
		Anonymous: false,
		Publish: true
	},
	methods: {
		submit() {
			axios
				.post("/api/Feedback", {
					Comment: this.Comment,
					Anonymous: this.Anonymous,
					Publish: this.Publish
				}).then(response => {
					console.log("cao")
				})
        }
	}
})