import { createStore } from 'vuex'
import login from "./modules/login"
import pages from "./modules/pages"
import dashboard from "./modules/dashboard"
import groupsAccessRights from "./modules/groups-access-rights"
import bonLivraison from "./modules/bon-livraison"
import config from "./modules/config"

export const store = createStore({
  modules: {
    login,
    pages,
    dashboard,
    groupsAccessRights,
    bonLivraison,
    config
  }
})