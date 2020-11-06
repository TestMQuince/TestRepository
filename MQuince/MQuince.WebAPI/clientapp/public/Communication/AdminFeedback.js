var app = new Vue({
	el: '#adminFeedback',
	data: {
		status: "Published",
		feedbacks: []
	},
	methods: {
		statusChanged() {

		}
	},
	created() {
		axios
			.get('/api/Feedback/GetByStatus', {
				params: {
					publish: true
				}
			}).then(response => {
				this.feedbacks = response.data
			})

    }
})