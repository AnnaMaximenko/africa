<template>
  <Header />
  <Section1Html />
  <Section2Html />
  <Section3Html />
  <Section4Html />
  <Section5Html />
  <Footer />
</template>

<script>
import Header from "@/components/Header.vue";
import Section1Html from "@/components/Section1Html.vue";
import Section2Html from "@/components/Section2Html.vue";
import Section3Html from "@/components/Section3Html.vue";
import Section4Html from "@/components/Section4Html.vue";
import Section5Html from "@/components/Section5Html.vue";
import Section5Html from "@/components/Section6Html.vue";
import Footer from "@/components/Footer.vue";
export default {
  components: {
    Header,
    Section1Html,
    Section2Html,
    Section3Html,
    Section4Html,
    Section5Html,
    Footer,
  },
};
</script>

<style lang="scss" scoped></style>
