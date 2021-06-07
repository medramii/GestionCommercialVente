<template>
  <h5>{{getMsg}}</h5>
  <button @click="upperCase">upperCase</button>
  <button @click="lowerCase">lowerCase</button>
  <button @click="concat">Concat</button>
  <button @click="upp_after_delai">Delai Action</button>
</template>

<script>
import {mapGetters, mapMutations} from "vuex"
export default {
  data() {
      return {
          msg: ""
      }
  },
  computed: {
        ...mapGetters(
          'testModule',
          [
            "getMsg",
          ]
        )
  },
  methods: {
        ...mapMutations(
          'testModule',
          [
            "upperCase",
            "lowerCase",
          ]
        ),
        concat() {
            this.$store.commit("testModule/concat", {
                txt: " Mr. Romerro"
            })
        },
        upp_after_delai() {
            this.$store.dispatch('testModule/uppAfterDelai')
        }
  }
}
</script>
