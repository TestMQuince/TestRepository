var app = new Vue({
	el: '#feedbacks',
	data: {
		feedbacks: []
	},
	methods: {

	},
	created() {
		axios
<<<<<<< HEAD
			.get('/api/Feedback/GetByStatus', {
				params: {
					publish: true,
=======
			.get('/api/Feedback/GetByAllParams', {
				params: {
					publish: true,
					anonymous: false,
>>>>>>> develop
					approved: true
				}
			}).then(response => {
				this.feedbacks = response.data
			})

	}
})