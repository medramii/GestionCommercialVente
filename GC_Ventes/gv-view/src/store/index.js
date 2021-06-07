import { createStore } from 'vuex'
import testModule from "./modules/testModule"
import login from "./modules/login"
import pages from "./modules/pages"

export const store = createStore({
  modules: {
    testModule,
    login,
    pages,
  }
})