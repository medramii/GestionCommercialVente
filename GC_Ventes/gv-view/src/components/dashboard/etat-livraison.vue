<template>
  <div>
    <div class="dx-fieldset">
      <div class="dx-field">
        <div class="dx-field-label" style="font-size: 16px">Date début</div>
        <div class="dx-field-value">
          <DxDateBox
            :value="date.start"
            type="date"
            @value-changed="onDateChange"
          />
        </div>
        <div class="dx-field-label"></div>
        <div class="dx-field-label" style="font-size: 16px">Date fin</div>
        <div class="dx-field-value">
          <DxDateBox
            :value="date.end"

            type="date"
            @value-changed="onDateChange"
          />
        </div>
      </div>
    </div>

    <DxResponsiveBox :screen-by-width="screen" single-column-screen="sm">
      <DxRow :ratio="1" />
      <DxRow :ratio="2" screen="sm" />

      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />

      <DxItem>
        <DxLocation :row="0" :col="0" :colspan="3" screen="lg" />
        <DxLocation :row="0" :col="0" :colspan="5" screen="sm" />
        <div>
          <DxChart
            class="dx-card responsive-paddings"
            id="chart"
            :data-source="this.getVentes"
            palette="Carmine"
            :sticky-hovering="true"
          >
            <DxCommonSeriesSettings
              type="spline"
              argument-field="month"
              hover-mode="includePoints"
            />
            <DxSeries
              v-for="type in typeVente"
              :key="type.value"
              :value-field="type.value"
              :name="type.name"
            />
            <DxMargin :bottom="20" />
            <DxArgumentAxis
              :value-margins-enabled="false"
              discrete-axis-division-mode="crossLabels"
            >
              <DxGrid :visible="true" />
            </DxArgumentAxis>
            <DxLegend
              vertical-alignment="bottom"
              horizontal-alignment="center"
              item-text-position="right"
            />
            <DxExport :enabled="true" />
            <DxTitle text="Vente mensuelle (Dhs)">
              <DxSubtitle text="(Local, Export ventes par mois)" />
            </DxTitle>
            <DxTooltip :enabled="true" />
          </DxChart>
        </div>
      </DxItem>

      <DxItem>
        <DxLocation :row="0" :col="3" :colspan="2" screen="lg" />
        <DxLocation :row="1" :col="0" :colspan="5" screen="sm" />
        <div>
          <DxPieChart
            class="dx-card responsive-paddings"
            id="pie"
            :data-source="this.getLivraisons"
            palette="Carmine"
            title="Revenu total par année (Dhs)"
          >
            <DxSeries argument-field="facture" value-field="count">
              <DxLabel
                :visible="true"
                :customize-text="formatLabel"
                position="columns"
              >
                <DxConnector :visible="true" :width="0.5" />
                <DxFont :size="16" />
              </DxLabel>
            </DxSeries>
            <DxLegend
              :column-count="4"
              orientation="horizontal"
              item-text-position="right"
              horizontal-alignment="center"
              vertical-alignment="bottom"
            />
            <DxExport :enabled="true" />
          </DxPieChart>
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
  DxRow,
} from "devextreme-vue/responsive-box";
import DxDateBox from 'devextreme-vue/date-box';
import { mapActions, mapGetters } from "vuex";
import {
  DxChart,
  DxSeries,
  DxArgumentAxis,
  DxCommonSeriesSettings,
  DxExport,
  DxGrid,
  DxMargin,
  DxLegend,
  DxTitle,
  DxSubtitle,
  DxTooltip,
} from "devextreme-vue/chart";
import DxPieChart, {
  DxLabel,
  DxConnector,
  DxFont,
} from "devextreme-vue/pie-chart";

export default {
  components: {
    DxResponsiveBox,
    DxItem,
    DxLocation,
    DxCol,
    DxRow,
    DxDateBox,
    DxChart,
    DxSeries,
    DxArgumentAxis,
    DxCommonSeriesSettings,
    DxExport,
    DxGrid,
    DxMargin,
    DxLegend,
    DxTitle,
    DxSubtitle,
    DxTooltip,
    DxPieChart,
    DxLabel,
    DxConnector,
    DxFont,
  },

  data() {
    return {
      screen(width) {
        return width < 1000 ? "sm" : "lg";
      },
      date: {
        "start": new Date(),
        "end": new Date()
      },
      typeVente: [
        { value: "facture", name: "Facturé" },
        { value: "count", name: "Non Facturé" },
      ],
    };
  },
  computed: {
    ...mapGetters({
      getVentes: "dashboard/getVentes",
      getLivraisons: "dashboard/getLivraisons",
    }),
  },
  methods: {
    ...mapActions({
      initVentes: "dashboard/initVentes",
      initLivraisons: "dashboard/initLivraisons",
    }),
    onDateChange: function () {
      let start = new Date(
            this.date.start
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          });
      let end = new Date(
              this.date.end
            ).toLocaleDateString("fr-CA", {
              year: "numeric",
              month: "2-digit",
              day: "2-digit",
            });

      console.log({start, end});
      this.initLivraisons({start, end});
    },
    formatLabel(pointInfo) {
      return `${pointInfo.valueText} (${pointInfo.percentText})`;
    },
  },
  beforeMount() {
    this.initVentes(2021);
    let start = new Date(
            this.date.start
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          });
    let end = new Date(
            this.date.end
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          });
    this.initLivraisons({start, end});
  },
};
</script>
<style>
.options {
  padding: 20px;
  background-color: rgba(191, 191, 191, 0.15);
  margin-top: 20px;
}

.option {
  margin-top: 10px;
}

.caption {
  font-size: 18px;
  font-weight: 500;
}

.option > span {
  margin-right: 14px;
}

.option > .dx-widget {
  display: inline-block;
  vertical-align: middle;
}
</style>
