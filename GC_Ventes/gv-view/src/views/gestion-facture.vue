<template>
  <div>
    <form id="form-container" class="content-block" @submit.prevent="SaveFacture()">
      <DxForm :form-data="getFacture" id="form" :col-count="3" 
        @field-data-changed="NotifyLivraisons">
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
              <h2 style="display: contents">{{ action }} facture</h2>
            </div>
          </template>
        </DxItem>
        <DxButtonItem
          :button-options="buttonOptions"
          horizontal-alignment="right"
        />
        <DxItem
          :editor-options="{ value: getNextFacture, disabled: true }"
          data-field="numFacture"
        />
        <DxItem
          v-if="action=='Modifier'"
          :editor-options="{
            value: getFacture.codeClient,
            searchEnabled: true,
            items: getClients,
            displayExpr: 'raisonSociale',
            valueExpr: 'codeClient',
          }"
          data-field="client"
          editor-type="dxSelectBox"
        >
          <DxRequiredRule message="Client est obligatoire" />
        </DxItem>
        <DxItem
          v-if="action=='Ajouter'"
          :editor-options="{
            searchEnabled: true,
            items: getClients,
            displayExpr: 'raisonSociale',
            valueExpr: 'codeClient',
          }"
          data-field="client"
          editor-type="dxSelectBox"
        >
          <DxRequiredRule message="Client est obligatoire" />
        </DxItem>
        <DxItem data-field="dateFacture" editor-type="dxDateBox">
          <DxRequiredRule message="La date est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: 'Local',
            items: ['Local', 'Export'],
          }"
          editor-type="dxSelectBox"
          data-field="typeDeVente"
        >
          <DxRequiredRule message="Type de vente est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: 'ESP',
            items: getModesReglement,
            displayExpr: 'designation',
            valueExpr: 'codeModeReg',
          }"
          editor-type="dxSelectBox"
          data-field="modeReglement"
        >
          <DxRequiredRule message="Devise est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: getFacture.devise,
            items: getDevises,
            displayExpr: 'designation',
            valueExpr: 'id',
          }"
          editor-type="dxSelectBox"
          data-field="devise"
        >
          <DxRequiredRule message="Devise est obligatoire" />
        </DxItem>
        <DxItem
          data-field="tauxDeChange"
          editor-type="dxNumberBox"
          :editor-options="{ 
            disabled: tcEnabled,
            value: getFacture.tauxDeChange,
            min: '1', 
            max: '15' 
          }"
        >
          <DxRequiredRule message="Taux de change est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{ value: getFacture.montantDevise, disabled: true }"
          data-field="montantDevise"
        />
        <DxItem
          :editor-options="{ value: getFacture.montantDh, disabled: true }"
          data-field="montantDh"
        />
        <DxItem data-field="dateEcheance" editor-type="dxDateBox">
          <DxRequiredRule message="La date est obligatoire" />
        </DxItem>
        <DxItem :col-span="2" data-field="observation" />
      </DxForm>
    </form>

<!-- ---------------------------- details -------------------------------------- -->

    <DxDataGrid
      class="content-block"
      :column-hiding-enabled="true"
      :show-borders="true"
      :data-source="getLivraisons"
      @editing-start="updated"
    > 
      <DxEditing
        :allow-updating="true"
        mode="cell"
        refresh-mode="repaint"
      />
      <DxColumn
        :width="100"
        data-field="facture"
        caption="Facturé"
      />
      <DxColumn
        :editor-options="{ disabled: true }"
        :width="100"
        data-field="numBl"
        caption="Numero"
      />
      <DxColumn
        :editor-options="{ disabled: true }"
        data-field="destination"
        caption="Destination"
      />
      <DxColumn
        :editor-options="{ disabled: true }"
        data-field="dateBl"
        data-type="date"
        caption="Date"
      />
      <DxColumn
        :editor-options="{ disabled: true }"
        :width="170"
        data-field="montantDh"
        caption="Prix total (Dhs)"
      />
      <DxColumn
        :editor-options="{ disabled: true }"
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
import { DxDataGrid, DxEditing, DxColumn, DxMasterDetail, } from "devextreme-vue/data-grid";
import DetailTemplate from '../components/facture/livraisons-template.vue';
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
    DxMasterDetail,
    DetailTemplate
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
      tcEnabled: false
    };
  },
  computed: {
    ...mapGetters({
      getFacture: "facture/getFactureInUse",
      getNextFacture: "facture/getNextFacture",
      getLivraisons: "facture/getLivraisons",
      getClients: "config/getClients",
      getDevises: "config/getDevises",
      getModesReglement: "config/getModesReglement",
    }),
  },
  methods: {
    ...mapActions({
      refreshLivraisons: "facture/refreshLivraisons",
      initDataForAdd: "facture/initDataForAdd",
      initDataForUpdate: "facture/initDataForUpdate",
      addFacture: "facture/addFacture",
      InitConfigData: "config/initConfig",
    }),
    updated() {
      let montant = 0;
      this.getLivraisons.forEach(e => {
          if (e.facture) {
            montant += e.montantDh;
          }
      });
      this.getFacture.montantDh = montant.toFixed(2);
      this.getFacture.montantDevise = (montant/this.getFacture.tauxDeChange).toFixed(2);
    },
    NotifyLivraisons(e) {
      if (e.dataField == "devise") {
        if (e.value == 1) {
          this.getFacture.tauxDeChange = 1;
          this.tcEnabled = true;
        } else this.tcEnabled = false;
        
      }
      if (e.dataField == "tauxDeChange") {
        this.updated();
      }
      if (e.dataField == "client" || e.dataField == "dateFacture") {
        let date = new Date(
            this.getFacture.dateFacture
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          });
        if (date != 'Invalid Date' && this.getFacture.client != '') {
          this.refreshLivraisons(
            {
              "idFac": isNaN(this.id) ? 0 : this.id,
              "codeClient": this.getFacture.client == '' ? this.getFacture.codeClient : this.getFacture.client,
              "dateFac": date,
            }
          );
        }
      }
    },
    dataValidation() {
      let livraisons = [];
      this.getLivraisons.forEach(e => {
          if (e.facture) livraisons.push(e.id);
      });
      if (livraisons.length < 1) {
        return "La facture doit contenir au moins une livraison...!!?";
      } else return true;
    },
    SaveFacture() {
      if (this.dataValidation() === true) {
        if (this.action == "Ajouter") {
          this.addFacture()
            .then(() => {
              notify(
                "La facture a etes ajouté avec success...!!",
                "success",
                2000
              );
              this.$router.back();
            })
            .catch(() => {
              notify("Echec..!!", "error", 1500);
            });
        }
        else if (this.action == "Modifier" && this.id > 0) {
          this.$store.dispatch("facture/editFacture", this.id);
          notify(
            "La facture a etes modifié avec success...!!",
            "success",
            2000
          );
          this.$router.back();
        }
      } else {
        notify(this.dataValidation(), "error", 2000);
      }
    },
  },
  beforeMount() {
    if (this.action == "Ajouter" && this.id == "nouveau") {
      this.InitConfigData();
      this.initDataForAdd();
    } else if (this.action == "Modifier" && this.id > 0) {
      this.InitConfigData();
      this.initDataForUpdate(this.id)
        .catch(() => {
          this.$router.back();
        });
    } else {
      this.$router.back();
    }
  },
  beforeUnmount() {
    this.$store.commit("facture/setFactureInUse", []);
    this.$store.commit("facture/setLivraisons", []);
    this.$store.commit("facture/setNextFacture", "");
  },
};
</script>