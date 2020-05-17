import axios from 'axios'

axios.defaults.baseURL = process.env.VUE_APP_WEBAPI
// axios.defaults.baseURL = 'http://localhost:50747/api'

const apiGeneric = {

  // get one item
  async getItem (route, id) {
    try {
      var response = await axios.get('/' + route + '/' + id)
      return response.data
    } catch (error) { return error.status }
  },

  // insert item
  async insertItem (route, item) {
    try {
      var response = await axios.post('/' + route, item)
      return response.data
    } catch (error) { return error.status }
  }
}

export default apiGeneric
