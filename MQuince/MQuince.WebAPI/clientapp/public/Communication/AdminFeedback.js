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
							publish: true,
							approved: true
						}
					}).then(response => {
						this.feedbacks = response.data
					})
			}
			else if (this.status == "Pending") {
				axios
					.get('/api/Feedback/GetByStatus', {
						params: {
							publish: true,
							approved: false
						}
					}).then(response => {
						this.feedbacks = response.data
					})
			}
			else if (this.status == "Private") {
				axios
					.get('/api/Feedback/GetByStatus', {
						params: {
							publish: false,
							approved: false
						}
					}).then(response => {
						this.feedbacks = response.data
					})
			}
		},
		approve: function (fdb) {
			fdb.entityDTO.approved = true
			axios
				.post("/api/Feedback/Update", {
					Id: fdb.id,
					Anonymous: fdb.entityDTO.anonymous,
					Approved: true,
					Comment: fdb.entityDTO.comment,
					Publish: fdb.entityDTO.publish,
					UserId: fdb.entityDTO.UserId
				})
				.then(response => {

				})
        }
	},
	created() {
		axios
			.get('/api/Feedback/GetByStatus', {
				params: {
					publish: true,
					approved: true
				}
			}).then(response => {
				this.feedbacks = response.data
			})

    }
})