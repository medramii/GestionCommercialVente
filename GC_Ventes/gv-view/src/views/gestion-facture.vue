<template>
  <div>
    <form id="form-container" class="content-block" @submit.prevent="SaveBl()">
      <DxForm :form-data="getFacture" id="form" :col-count="3">
        <DxItem :col-span="2">
          <template #default>
            <div>
              <DxButton
                icon="arrowleft"
                type="default"
                styling-mode="text"
                @click="this.$router.back()"
                style="
                  margin-bottom: 15px;
                  padding-right: 0px;
                  border-right-width: 5px;
                  margin-right: 5px;
                "
              />
              <!-- <h2 style="display: contents">{{ action }} facture</h2> -->
              <h2 style="display: contents">Ajouter facture</h2>
            </div>
          </template>
        </DxItem>
        <DxButtonItem
          :button-options="buttonOptions"
          horizontal-alignment="right"
        />
        <DxItem
          :editor-options="{ value: getNextBl, disabled: true }"
          data-field="numBl"
        />
        <DxItem
          :editor-options="{
            value: getFacture.codeClient,
            searchEnabled: true,
            items: getClients,
            displayExpr: 'raisonSociale',
            valueExpr: 'codeClient',
          }"
          data-field="codeClient"
          editor-type="dxSelectBox"
        >
          <DxRequiredRule message="Client est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: 'Local',
            items: ['Local', 'Export'],
          }"
          editor-type="dxSelectBox"
          data-field="typeVente"
        >
          <DxRequiredRule message="Type de vente est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: 'MAD',
            items: ['MAD', 'USD', 'EUR'],
          }"
          editor-type="dxSelectBox"
          data-field="devise"
        >
          <DxRequiredRule message="Devise est obligatoire" />
        </DxItem>
        <DxItem
          data-field="tauxDeChange"
          editor-type="dxNumberBox"
          :editor-options="{ value: 1, min: '1' }"
        >
          <DxRequiredRule message="Taux de change est obligatoire" />
        </DxItem>
        <DxItem data-field="dateBl" editor-type="dxDateBox">
          <DxRequiredRule message="La date est obligatoire" />
        </DxItem>
        <DxItem :col-span="2" data-field="observation" />
      </DxForm>
    </form>

<!-- ---------------------------- details -------------------------------------- -->

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
        refresh-mode="repaint"
      />
      <DxColumn
        :width="100"
        data-field="numBl"
        caption="Numero"
      />
      <DxColumn
        data-field="client.raisonSociale"
        caption="Client"
      />
      <DxColumn
        data-field="destination"
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
        data-field="devise"
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

<!-- --------------------------------------------------------------------------- -->
    

  </div>
</template>

<script>
import {
  DxForm,
  DxItem,
  DxRequiredRule,
  DxButtonItem,
} from "devextreme-vue/form";
import { DxDataGrid, DxEditing, DxColumn } from "devextreme-vue/data-grid";
import DxButton from "devextreme-vue/button";
import notify from "devextreme/ui/notify";
import { mapActions, mapGetters } from "vuex";

export default {
  components: {
    DxForm,
    DxItem,
    DxRequiredRule,
    DxButtonItem,
    DxButton,
    DxDataGrid,
    DxEditing,
    DxColumn,
  },
  data() {
    return {
      action: this.$route.params.action,
      id: this.$route.params.id,
      buttonOptions: {
        text: "Sauvegarder",
        type: "default",
        stylingMode: "text",
        useSubmitBehavior: true,
      },
    };
  },
  computed: {
    ...mapGetters({
      getFacture: "bonLivraison/getBlInUse",
      getNextBl: "bonLivraison/getNextBl",
      getLignesBl: "bonLivraison/getLignesBl",
      getClients: "config/getClients",
      getVilles: "config/getVilles",
      getArticles: "config/getArticles",
      getMagasins: "config/getMagasins",
    }),
  },
  methods: {
    ...mapActions({
      initDataForAdd: "bonLivraison/initDataForAdd",
      initDataForUpdate: "bonLivraison/initDataForUpdate",
      addBl: "bonLivraison/addBL",
      configData: "config/initConfig",
    }),
    dataValidation() {
      if (this.getLignesBl.length < 1) {
        return "La livraison doit contenir au moins un article...!!?";
      } else return true;
    },
    SaveBl() {
      if (this.dataValidation() === true) {
        if (this.action == "Ajouter") {
          // this.$store.dispatch('bonLivraison/addBL');
          this.addBl()
            .then(() => {
              notify(
                "Le bon de livraison a etes ajouté avec success...!!",
                "success",
                2000
              );
              this.$router.go(-1);
            })
            .catch(() => {
              notify("Echec..!!", "error", 1500);
            });
        } else if (this.action == "Modifier" && this.id > 0) {
          this.$store.dispatch("bonLivraison/editBL", this.id);
          notify(
            "Le bon de livraison a etes modifié avec success...!!",
            "success",
            2000
          );
          this.$router.go(-1);
        }
      } else {
        notify(this.dataValidation(), "error", 2000);
      }
    },
  },
  beforeMount() {

  },
  beforeUnmount() {
    
  },
};
</script>