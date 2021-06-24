import { createStore } from 'vuex'
import login from "./modules/login"
import pages from "./modules/pages"
import dashboard from "./modules/dashboard"
import groupsAccessRights from "./modules/groups-access-rights"
import config from "./modules/config"
import bonLivraison from "./modules/bon-livraison"
import facture from "./modules/facture"

export const store = createStore({
  modules: {
    login,
    pages,
    dashboard,
    groupsAccessRights,
    config,
    bonLivraison,
    facture,
  }
})