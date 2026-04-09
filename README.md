# 🌿 Branche principale

## 👨‍💻 Objectif principal

Cette branche est dédiée au développement et à l'isolation des tâches assignées à Emeric. Elle sert de zone de travail individuelle avant que les fonctionnalités ou correctifs ne soient soumis à revue et fusionnés dans la branche principale (`main`).

## 🎯 Tâches en cours / Changements majeurs

- **[À COMPLETER]** : Description courte de la fonctionnalité sur laquelle vous travaillez (Ex: "Implémentation du système de connexion").
- **[À COMPLETER]** : Tout autre correctif ou ajout important.

### Status de la Branche

| Élément | Statut | Notes |
| :--- | :--- | :--- |
| **Code en cours** | 🚧 En développement | |
| **Fusion prévue dans `main`** | 🗓️ Date/Événement estimé | (Ex: Fin de semaine prochaine, après validation des tests) |
| **Branche parente** | `main` | Cette branche a été créée à partir de la dernière version stable de `main`. |

## 🚀 Comment l'intégrer dans `main` (Workflow)

Lorsque le travail sur cette branche sera terminé :

1.  **Vérification** : Assurez-vous que le code est bien testé localement.
2.  **Mise à jour (si besoin)** : Tirez les derniers changements de `main` dans cette branche pour résoudre les conflits avant la PR :
    ```bash
    git pull origin main
    ```
3.  **Pull Request (PR)** : Créer une Pull Request sur GitHub pour demander la fusion de `Emeric` vers `main`.

## ⚠️ À l'intention du Collaborateur

Cher Collaborateur,

Veuillez ne pas commiter directement sur cette branche. Si vous avez besoin de reprendre le travail ici, veuillez en discuter d'abord ou, idéalement, ouvrir une nouvelle **branche de fonctionnalité** à partir de `Emeric` si une tâche est dépendante.
