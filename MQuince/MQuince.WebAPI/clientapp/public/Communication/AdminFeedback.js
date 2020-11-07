var app = new Vue({
	el: '#adminFeedback',
	data: {
		status: "Published",
		feedbacks: []
	},
	methods: {
		statusChanged() {
			if (this.status == "Published") {
				axios
					.get('/api/Feedback/GetByStatus', {
						params: {
							publish: true
						}
					}).then(response => {
						this.feedbacks = response.data
					})
			}
			else if (this.status == "Pending") {
				axios
					.get('/api/Feedback/GetByStatus', {
						params: {
							publish: false
						}
					}).then(response => {
						this.feedbacks = response.data
					})
            }
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