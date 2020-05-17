<template>
  <div>
    <h2>URL</h2>
    <h4>{{ $route.params.id }}</h4>
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
    }
  },

  computed: {

  },

  created () {

  },

  mounted () {
    this.getUrl(this.$route.params.id)
  },

  methods: {

    getUrl (id) {
      if (id == null || id === undefined) return

      apiGeneric.getItem('Url', id)
        .then((data) => {
          // alert(data)
          window.location.assign(data)
        })
        .catch((error) => {
          alert('ERROR: ' + error)
        })
    }
  }
}
</script>
