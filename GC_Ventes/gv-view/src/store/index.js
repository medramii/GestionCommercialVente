import { createStore } from 'vuex'
import testModule from "./modules/testModule"///////////
import login from "./modules/login"
import pages from "./modules/pages"
import groupsAccessRights from "./modules/groups-access-rights"
import bonLivraison from "./modules/bon-livraison"
import config from "./modules/config"

export const store = createStore({
  modules: {
    testModule,///////
    login,
    pages,
    groupsAccessRights,
    bonLivraison,
    config
  }
})