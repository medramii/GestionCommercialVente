<template>
  <div class="content-block">
    <!-- <h2>Dashboard</h2> -->
    <h2>Bonjour {{getSignedUser.prenom+' '+getSignedUser.nom}}</h2>
    <DxResponsiveBox :screen-by-width="screen" single-column-screen="sm">
      <DxRow :ratio="1" />
      <DxRow :ratio="1" />
      <DxRow :ratio="2" screen="sm" />

      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />

      <DxCol :ratio="4" screen="sm" />

      <DxItem>
        <DxLocation :row="0" :col="0" :colspan="1" screen="lg" />
        <DxLocation :row="0" :col="0" :colspan="2" screen="md" />
        <DxLocation :row="0" :col="0" :colspan="1" screen="sm" />
        <div
          v-if="getSignedUser.idGroupe == 1"
          class="dx-card responsive-paddings"
          @click="onDsClick('gestion-des-groupes')"
        >
          <img src="../assets/groups.png" alt="">
          <h6>Gestion des groupes</h6>
        </div>
        <div
          v-else-if="getSignedUser.idGroupe == 2"
          class="dx-card responsive-paddings"
          @click="onDsClick('facturation')"
        >
          <img src="../assets/bill.png" alt="">
          <h6>Facturation</h6>
        </div>
        <div
          v-else-if="getSignedUser.idGroupe == 3"
          class="dx-card responsive-paddings"
          @click="onDsClick('bon-de-livraison')"
        >
          <img src="../assets/bl.png" alt="">
          <h6>Bon de livraison</h6>
        </div>
        <div
          v-else-if="getSignedUser.idGroupe == 4"
          class="dx-card responsive-paddings"
          @click="onDsClick('')"
        >
          <img src="../assets/report.png" alt="">
          <h6>Rapport commerciale</h6>
        </div>
      </DxItem>
      <DxItem>
        <DxLocation :row="0" :col="1" :colspan="1" screen="lg" />
        <DxLocation :row="0" :col="2" :colspan="2" screen="md" />
        <DxLocation :row="0" :col="1" :colspan="1" screen="sm" />
        <div
          class="dx-card responsive-paddings"
          @click="onDsClick('vente-statistics')"
        >
          <img src="../assets/sales.png" alt="">
          <h6>Statistiques de vente</h6>
        </div>
      </DxItem>
      <DxItem>
        <DxLocation :row="0" :col="2" :colspan="1" screen="lg" />
        <DxLocation :row="1" :col="0" :colspan="2" screen="md" />
        <DxLocation :row="0" :col="2" :colspan="1" screen="sm" />
        <div
          class="dx-card responsive-paddings"
          @click="onDsClick('etat-bon-livraison')"
        >
          <img src="../assets/delivery.png" alt="">
          <h6>Etat de bon de livraison</h6>
        </div>
      </DxItem>
      <DxItem>
        <DxLocation :row="0" :col="3" :colspan="1" screen="lg" />
        <DxLocation :row="1" :col="2" :colspan="2" screen="md" />
        <DxLocation :row="1" :col="3" :colspan="1" screen="sm" />
        <div
          class="dx-card responsive-paddings"
          @click="onDsClick('stock')"
        >
          <img src="../assets/stock.png" alt="">
          <h6>Etat de stock</h6>
        </div>
      </DxItem>

    </DxResponsiveBox>
  </div>
</template>

<script>
import {
  DxResponsiveBox,
  DxItem,
  DxLocation,
  DxCol,
  DxRow
} from "devextreme-vue/responsive-box";
import { mapGetters } from 'vuex';
export default {
  components: {
    DxResponsiveBox,
    DxItem,
    DxLocation,
    DxCol,
    DxRow
  },
  data() {
    return {
      screen(width) {
        if (width < 900 && width > 550) return "md";
        if (width <= 550) return "sm";
        else return "lg";
      },
    };
  },
  computed: {
    ...mapGetters({
      getSignedUser: "login/getSignedUser",
    }),
  },
  methods: {
    onDsClick(page) {
      this.$router.push(page);
    }
  },
  beforeMount () {
    console.log(this.getSignedUser.idGroupe);
  }
};
</script>
<style lang="scss" scoped>
.dx-card {
  border-radius: 7px;
  cursor: pointer;
  text-align: center;
  margin-top: 25px;
  padding-top: 20px !important;
  padding-bottom: 15px !important;
  margin-inline: 10px;
  // max-width: 260px !important;
  max-height: 250px;
  /* height: auto !important; */
  h6{
    margin: 0;
    margin-top: 5px;
  }
  img{
    max-height: 100px;
    max-width: 100px;
    margin: 0px auto;
  }
}
.dx-card:hover {
  box-shadow: none;
}
</style>