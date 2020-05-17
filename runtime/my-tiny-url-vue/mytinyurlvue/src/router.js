import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'

import Url from './views/Url.vue'
import UrlCreate from './views/UrlCreate.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [

    { path: '/', name: 'home', component: Home },
    { path: '/url', name: 'Url', component: Url },
    { path: '/url/:id', name: 'UrlId', component: Url },
    { path: '/urlcreate', name: 'UrlCreate', component: UrlCreate }

  ]
})
