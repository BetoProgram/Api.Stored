import { createRouter, createWebHistory } from 'vue-router';

const routes = [
  { 
    path: "/",
    meta:{ layout: 'no-default'},
    component: () => import('./modules/auth/pages/LoginPage.vue')
  },
  {
    path: "/login",
    meta:{ layout: 'no-default'},
    component: () => import('./modules/auth/pages/LoginPage.vue')
  },
  {
    path: '/home',
    name: 'home',
    meta: { auth: true },
    component: () => import('./modules/home/page/HomePage.vue')
  },
  {
    path: '/:pathMatch(.*)*',
    component: () => import('./modules/auth/pages/LoginPage.vue')
}
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;