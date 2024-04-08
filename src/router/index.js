import { createRouter, createWebHistory } from "vue-router";
// import HomeView from '../views/HomeView.vue'
import HomePage from "@/pages/HomePage";

const routes = [
  {
    path: "/",
    name: "home",
    component: HomePage,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
