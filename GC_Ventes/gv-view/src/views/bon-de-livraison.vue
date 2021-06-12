<template>
  <div>
    <h2 class="content-block">Bon de livraison</h2>
    <DxDataGrid
      class="content-block"
      id="grid-container"
      :show-borders="false"
      :data-source="dataSource"
      key-expr="numBL"
    >
      <DxColumn
        :width="100"
        data-field="numBL"
        caption="Numero"
      />
      <DxColumn
        data-field="codeClient"
        caption="Client"
      />
      <DxColumn
        data-field="destination"
        caption="Destination"
      />
      <DxColumn
        data-field="dateBL"
        data-type="date"
        caption="Date"
      />
      <DxColumn
        :width="170"
        data-field="montantDH"
        caption="Prix total (Dhs)"
      />
      <DxMasterDetail
        :enabled="true"
        template="masterDetailTemplate"
      />
      <template #masterDetailTemplate="{ data: bl }">
        <DetailTemplate
          :BlData="bl"
        />
      </template>
    </DxDataGrid>
  </div>
</template>
<script>
import {
  DxDataGrid,
  DxColumn,
  DxMasterDetail,
} from 'devextreme-vue/data-grid';
import {mapGetters, mapActions} from "vuex"

import DetailTemplate from '../components/bon_livraison/master-template.vue';

export default {
  data() {
    return {
      dataSource: this.getBLs()
    };
  },
  computed: {

  },
  methods: {
    ...mapGetters(
      {
        getBLs: "bonLivraison/getBLs",
      },
    ),
    ...mapActions({
      initBLs: "bonLivraison/initBLs",
    }),
  },
  components: {
    DxDataGrid,
    DxColumn,
    DxMasterDetail,
    DetailTemplate
  },
  mounted() {
    this.initBLs();
    console.log(this.getBLs());
  }
};
</script>
<style>
#grid-container {
    height: 440px;
}
</style>
