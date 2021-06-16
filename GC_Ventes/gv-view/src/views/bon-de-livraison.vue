<template>
  <div>
    <h2 class="content-block">Bon de livraison</h2>
    <DxDataGrid
      class="content-block"
      :focused-row-enabled="true"
      :column-auto-width="true"
      :column-hiding-enabled="true"
      id="grid-container"
      :ref="gridRefName"
      :selection="{ mode: 'single' }"
      :show-borders="false"
      :data-source="dataSource"
      key-expr="id"
      @selection-changed="selectedChanged"
    >
      <DxFilterRow :visible="true" />
      <DxPaging 
        :page-size="10"
      />
      <DxPager 
        :show-page-size-selector="true" 
        :show-info="true" 
      />
      <DxEditing
        :refresh-mode="refreshMode"
      />
      <DxColumn
        :width="100"
        data-field="numBl"
        caption="Numero"
      />
      <DxColumn
        data-field="codeClient"
        caption="Client"
      />
      <DxColumn
        data-field="idDestinationNavigation.ville"
        caption="Destination"
      />
      <DxColumn
        data-field="dateBl"
        data-type="date"
        caption="Date"
      />
      <DxColumn
        :width="170"
        data-field="montantDh"
        caption="Prix total (Dhs)"
      />
      <DxColumn
        :width="500"
        data-field="typeVente"
        caption="Type de vente"
      />
      <DxColumn
        :width="500"
        data-field="idDevise"
        caption="Devise"
      />
      <DxColumn
        :width="500"
        data-field="tauxDeChange"
        caption="Taux de change"
      />
      <DxColumn
        :width="500"
        data-field="observation"
        caption="Observation"
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
    <DxSpeedDialAction
      :index="1"
      :on-click="addBL"
      icon="add"
      label="Ajouter"
    />
    <DxSpeedDialAction
      :visible="selectedRowIndex !== -1"
      :on-click="deleteBL"
      :index="2"
      icon="trash"
      label="Supprimer"
    />
    <DxSpeedDialAction
      :visible="selectedRowIndex !== -1"
      :on-click="editBL"
      :index="3"
      icon="edit"
      label="Modifier"
    />
  </div>
</template>
<script>
import {
  DxDataGrid,
  DxFilterRow,
  DxPager,
  DxPaging,
  DxEditing,
  DxColumn,
  DxMasterDetail,
} from 'devextreme-vue/data-grid';
import CustomStore from 'devextreme/data/custom_store';
import DxSpeedDialAction from 'devextreme-vue/speed-dial-action';
import {mapGetters, mapActions} from "vuex"

import DetailTemplate from '../components/bon_livraison/master-template.vue';

export default {
  data() {
    return {
      gridRefName: 'grid',
      refreshMode: 'full',
      dataSource: new CustomStore({
        key: 'id',
        load: async () => {
          await this.initBLs();
          return this.getBLs();
        },
        remove: () => {
          this.onDeleteBL();
        }
      }),
      selectedBlId: null,
      selectedRowIndex: -1
    };
  },
  computed: {
    grid: function() {
      return this.$refs[this.gridRefName].instance;
    }
  },
  methods: {
    ...mapGetters(
      {
        getBLs: "bonLivraison/getBLs",
      },
    ),
    ...mapActions(
      {
        initBLs: "bonLivraison/initBLs",
      }
    ),
    selectedChanged(e) {
      this.selectedBlId = e.selectedRowKeys[0];
      this.selectedRowIndex = e.component.getRowIndexByKey(e.selectedRowKeys[0]);
    },
    addBL: function() {
      this.$router.push({name: 'add-bon-livraison', params: {action: "Ajouter", id: "new"}})
    },
    editBL: function() {
      this.$router.push({name: 'add-bon-livraison', params: {action: "Modifier", id: this.selectedBlId}})
    },
    deleteBL: async function() {
      this.grid.deleteRow(this.selectedRowIndex);
    },
    onDeleteBL: function() {
      this.$store.dispatch('bonLivraison/deleteBL', this.selectedBlId);
    }
  },
  components: {
    DxDataGrid,
    DxFilterRow,
    DxPager,
    DxPaging,
    DxEditing,
    DxColumn,
    DxMasterDetail,
    DxSpeedDialAction,
    DetailTemplate
  },
};
</script>
<style>
#grid-container {
    height: 440px;
}
</style>
