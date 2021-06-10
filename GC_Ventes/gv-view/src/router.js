import { createRouter, createWebHistory } from "vue-router";

import routes from "./routes"
import {store} from "./store"

const router = new createRouter({
  routes,
  history: createWebHistory()
});

router.beforeEach((to, from, next) => {
  const logged = !!store.state.login.signedUser; // check if the user is logged in or not
  const pages = JSON.parse(localStorage.getItem("Pages")) || [];
  const names = pages.map(item => item.text.replace(" ", "-").toLowerCase());
  console.log(names);
  if (to.name === "default") next();
  if (to.name === "login" && logged) next({ name: "home" }); // if user is logged . redirect to home

  if (to.matched.some(record => record.meta.requiresAuth)) // if a router requires authentication
  {
    if (!logged) next({name: "login"}); // redirect to login if is not logged in
    else if(names.includes(to.name)) next();
    else next({ name: from.name }); // conitnue to route if logged in
  }
  else next(); // conitnue to route if a router doesn't require authentication
});

export default router;
