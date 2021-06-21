import Home from "./views/home";
import DsVentes from "./views/ds-ventes";
import defaultLayout from "./layouts/side-nav-inner-toolbar";
import simpleLayout from "./layouts/single-card";

function loadView(view) {
  return () => import (`./views/${view}.vue`)
}

export default [
  {
    name: "home",
    path: "/home",
    replace: true,
    meta: {
      requiresAuth: true,
      layout: defaultLayout
    },
    component: Home
  },
  {
    name: "vente-statistics",
    path: "/vente-statistics",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: DsVentes
  },
  {
    name: "groups-management",
    path: "/groups-management",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: loadView("groups-management")
  },
  {
    name: "bon-de-livraison",
    path: "/bon-de-livraison",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: loadView("bon-de-livraison")
  },
  {
    name: "gestion-bon-livraison",
    path: "/bon-de-livraison/:action/:id",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: loadView("gestion-bon-livraison")
  },
  {
    name: "facturation",
    path: "/facturation",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: loadView("facture")
  },




  
  {
    name: "login",
    path: "/login",
    replace: true,
    meta: {
      requiresAuth: false,
      layout: simpleLayout,
      title: "Sign In"
    },
    component: loadView("login-form")
  },
  {
    name: "default",
    path: "/",
    redirect: "home"
  },
  {
    name: "default",
    path: "/:pathMatch(.*)*",
    redirect: "login"
  }
];