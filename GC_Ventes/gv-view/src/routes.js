import Dashboard from "./views/dashboard";
import DsVentes from "./views/ds-ventes";
import DsLivraisons from "./views/ds-livraisons";
import defaultLayout from "./layouts/side-nav-inner-toolbar";
import simpleLayout from "./layouts/single-card";

function loadView(view) {
  return () => import (`./views/${view}.vue`)
}

export default [
  {
    name: "dashboard",
    path: "/dashboard",
    replace: true,
    meta: {
      requiresAuth: true,
      layout: defaultLayout
    },
    component: Dashboard
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
    name: "etat-bon-livraison",
    path: "/etat-bon-livraison",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: DsLivraisons
  },
  {
    name: "gestion-des-groupes",
    path: "/gestion-des-groupes",
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
    name: "gestion-facture",
    path: "/facturation/:action/:id",
    meta: { 
      requiresAuth: true,
      layout: defaultLayout
    },
    component: loadView("gestion-facture")
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
    redirect: "dashboard"
  },
  {
    name: "default",
    path: "/:pathMatch(.*)*",
    redirect: "login"
  }
];