var app = new Vue({
	el: '#app',
	data: {
		message: 'Hello Vue!',
		als: []
	},
	methods: {
		f: function () {
			this.message = 'funkcija'
			axios
				.get('/weatherforecast/proba')
				.then(response => {
					this.als = response.data
					console.log(this.als)
				});
		}
	},
	created() {
		this.message = 'Ipak nista'
	}
})