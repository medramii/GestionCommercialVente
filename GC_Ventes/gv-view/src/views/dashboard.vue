<template>
  <div class="content-block">
    <h2>Dashboard</h2>
    <DxResponsiveBox :screen-by-width="screen" single-column-screen="sm">
      <DxRow :ratio="1" />
      <DxRow :ratio="2" screen="sm" />

      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />

      <DxItem>
        <DxLocation :row="0" :col="0" :colspan="1" screen="lg" />
        <DxLocation :row="0" :col="0" :colspan="1" screen="sm" />
        <div 
          class="dx-card responsive-paddings"
          @click="onDsClick('bon-de-livraison')"
        >
          <img src="../assets/bl.png" alt="">
          <h6>Bon de livraison</h6>
        </div>
      </DxItem>
      <DxItem>
        <DxLocation :row="0" :col="1" :colspan="1" screen="lg" />
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
        <DxLocation :row="1" :col="0" :colspan="1" screen="sm" />
        <div 
          class="dx-card responsive-paddings"
          @click="onDsClick('')"
        >
          <img src="../assets/delivery.png" alt="">
          <h6>Etat de bon de livraison</h6>
        </div>
      </DxItem>
      <DxItem>
        <DxLocation :row="0" :col="3" :colspan="1" screen="lg" />
        <DxLocation :row="1" :col="1" :colspan="1" screen="sm" />
        <div
          class="dx-card responsive-paddings"
          @click="onDsClick('')"
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
        return width < 700 ? "sm" : "lg";
      },
    };
  },
  methods: {
    onDsClick(page) {
      this.$router.push(page);
    }
  }
};
</script>
<style lang="scss" scoped>
.dx-card {
  border-radius: 7px;
  cursor: pointer;
  text-align: center;
  padding-top: 20px !important;
  padding-bottom: 15px !important;
  margin-inline: 10px;
  max-width: 260px !important;
  /* height: auto !important; */
  h6{
    margin: 0;
    margin-top: 5px;
  }
}
.dx-card:hover {
  box-shadow: none;
}
</style>