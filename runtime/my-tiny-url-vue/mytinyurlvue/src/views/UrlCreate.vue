<template>
  <div>
    <h2>URL CREATE</h2>
    <input style="width: 300px;" v-model="editedItem.url" placeholder="Insert Url">
    <br />
    <input style="width: 300px;" v-model="editedItem.tinyurlshow" >
    <br />
    <input type="submit" value="Save" @click="saveUrl" >
  </div>
</template>
<script>

import apiGeneric from '../api/api.Generic'

export default {
  components: {

  },
  /*
  props: {
    name: {
      type: String,
      default: null
    }
  },
  */
  data () {
    return {

      editedItem: {
        url: null,
        tinyurl: null
      }

    }
  },

  methods: {

    saveUrl () {
      if (this.editedItem.url == null || this.editedItem.url === '') return

      apiGeneric.insertItem('Url', this.editedItem)
        .then((data) => {
          // alert(data)
          this.editedItem = data
        })
        .catch((error) => {
          alert('ERRO: ' + error)
        })
    }
  }
}
</script>
