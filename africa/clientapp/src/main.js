import { createApp } from 'vue'
import Vuelidate from 'vuelidate'
import App from './App.vue'
import router from './router'
import store from './store'
import "./assets/scss/style.scss";

createApp(App).use(store).use(Vuelidate).use(router).mount('#app')

