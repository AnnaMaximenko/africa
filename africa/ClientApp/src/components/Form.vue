<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <form @submit.prevent="onSendApplication"
          id="myDropdown"
          class="form center">
        <h3 class="form__title">Application form</h3>
        <div class="form__input_box">
            <label class="form__label">Name</label>
            <input class="form__input"
                   :class="{ 'form__input_hasError': (v$.name.$invalid && v$.name.$dirty) }"
                   v-model="application.name"
                   type="text"
                   name="name" />
            <p class="form__error_message"
               v-for="err in v$.name.$errors"
               :key="err.$uid">
                *{{ err.$message }}
            </p>
        </div>
        <div class="form__input_box">
            <label class="form__label">Phone</label>
            <input v-model="application.phoneNumber"
                   :class="{ 'form__input_hasError': (v$.phoneNumber.$invalid && v$.phoneNumber.$dirty) }"
                   class="form__input"
                   type="tel"
                   name="phoneNumber" />
            <p class="form__error_message"
               v-for="err in v$.phoneNumber.$errors"
               :key="err.$uid">
                *{{ err.$message }}
            </p>
        </div>
        <div class="form__input_box">
            <label class="form__label">Email</label>
            <input v-model.trim="application.email"
                   :class="{ 'form__input_hasError': (v$.email.$invalid && v$.email.$dirty) }"
                   class="form__input"
                   type="text"
                   name="email" />
            <p class="form__error_message"
               v-for="err in v$.email.$errors"
               :key="err.$uid">
                *{{ err.$message }}
            </p>
        </div>
        <button type="submit" class="form__button">Send</button>
    </form>
    <transition name ="popup__fade" appear>
        <div class="popup" v-if="visible.value">
            <div class="popup__inner">
                <p class="popup__title">Thank you for contacting us!</p>
                <p class="popup__text">
                        We have received your contact information<br />
                        and will reach out to you as soon as possible
                </p>
                <button class="popup__button" @click="visible.value = false">Close</button>
            </div>
        </div>
    </transition>
</template>

<script>
    import axios from 'axios';
    import { reactive, computed } from 'vue';
    import { email, required } from '@vuelidate/validators';
    import { useVuelidate } from '@vuelidate/core';

    export default {
        setup() {
            const application = reactive({
                name: '',
                phoneNumber: '',
                email: '',
            });

            const rules = computed(() => ({
                name: { required },
                phoneNumber: { required },
                email: { required, email }
            }));

            const v$ = useVuelidate(rules, application);

            const visible = reactive({ value: false });

            const resetForm = () => {
                application.name = '';
                application.phoneNumber = '';
                application.email = '';
            };

            return {
                application,
                v$,
                visible,
                resetForm,
            };
        },

        methods: {
            async onSendApplication() {
                this.v$.$touch();
                if (!this.v$.$invalid) {
                    try {
                        await axios.post('api/Applications', {
                            name: this.application.name,
                            phoneNumber: this.application.phoneNumber,
                            email: this.application.email,
                        });
                    } catch (error) {
                        console.error('Error submitting application:', error.response);
                    }
                    this.visible.value = true;
                    this.resetForm();
                    this.v$.$reset();
                }
            },
        }
    };
</script>
