import { createRouter, createWebHistory } from "vue-router";

import Home from "./views/home";
import Tasks from "./views/tasks";
import defaultLayout from "./layouts/side-nav-inner-toolbar";
import simpleLayout from "./layouts/single-card";

import {store} from "./store"

function loadView(view) {
  return () => import (`./views/${view}.vue`)
}

const routes = [
  {
    path: "/home",
    name: "home",
    replace: true,
    meta: {
      requiresAuth: true,
      layout: defaultLayout
    },
    component: Home
  },
  {
    path: "/tasks",
    name: "tasks",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: Tasks
  },
  {
    path: "/groups-management",
    name: "groups-management",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: loadView("groups-management")
  },
  {
    path: "/login",
    name: "login",
    replace: true,
    meta: {
      requiresAuth: false,
      layout: simpleLayout,
      title: "Sign In"
    },
    component: loadView("login-form")
  },
  {
    path: "/",
    redirect: "home"
  },
  {
    path: "/:pathMatch(.*)*",
    redirect: "login"
  }
];

const router = new createRouter({
  routes,
  history: createWebHistory()
});

router.beforeEach((to, from, next) => {
  const logged = !!store.state.login.signedUser; // check if the user is logged in or not

  if (to.name === "login" && logged) next({ name: "home" }); // if user is logged . redirect to home

  if (to.matched.some(record => record.meta.requiresAuth)) // if a router requires authentication
  {
    if (!logged) next({name: "login"}); // redirect to login if is not logged in
    else next(); // conitnue to route if logged in
  }
  else next(); // conitnue to route if a router doesn't require authentication
});

export default router;
