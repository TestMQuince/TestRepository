var app = new Vue({
	el: '#feedbacks',
	data: {
		feedbacks: []
	},
	methods: {

	},
	created() {
		axios
			.get('/api/Feedback/GetByAllParams', {
				params: {
					publish: true,
					anonymous: false,
					approved: true
				}
			}).then(response => {
				this.feedbacks = response.data
			})

	}
})