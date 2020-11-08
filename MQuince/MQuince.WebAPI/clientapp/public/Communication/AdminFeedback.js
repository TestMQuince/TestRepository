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
<<<<<<< HEAD
							publish: true,
							approved: true
=======
							publish: true
>>>>>>> develop
						}
					}).then(response => {
						this.feedbacks = response.data
					})
			}
			else if (this.status == "Pending") {
				axios
					.get('/api/Feedback/GetByStatus', {
						params: {
<<<<<<< HEAD
							publish: true,
							approved: false
=======
							publish: false
>>>>>>> develop
						}
					}).then(response => {
						this.feedbacks = response.data
					})
<<<<<<< HEAD
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
=======
            }
		}
>>>>>>> develop
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